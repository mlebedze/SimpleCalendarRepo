using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCalendar
{
    /// <summary>
    /// Calendar service form.</summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// The currently selected date.</summary>
        public DateTime dateSelected = DateTime.Today;
        //public Dictionary<DateTime, Dictionary<CalendarCategory, List<CalendarEvent>>> eventsCollection = new Dictionary<DateTime, Dictionary<CalendarCategory, List<CalendarEvent>>>();

        /// <summary>
        /// All user-created event categories.</summary>
        private Dictionary<string, CalendarCategory> eventCategories;

        /// <summary>
        /// All user-created events.</summary>
        private SortedSet<CalendarEvent> allEvents;

        /// <summary>
        /// All events which start on the currently selected date.</summary>
        private SortedSet<CalendarEvent> todaysEvents;

        /// <summary>
        /// The current event being modified.</summary>
        private CalendarEvent currentEvent;

        #region initialization
        /// <summary>
        /// Initializes the calendar form.</summary>
        public Form1()
        {
            // set up components on the form
            InitializeComponent();

            // get the clock ready right away
            UpdateClock();

            // load up saved calendar data from file
            loadEventsFromFile(null, out eventCategories, out allEvents);

            // mouse event handlers to make the form draggable
            currentTimeDisplay.MouseDown += TopPanel_MouseDown;
            currentTimeDisplay.MouseMove += TopPanel_MouseMove;
            currentTimeDisplay.MouseUp += TopPanel_MouseUp;
            spacerFormTime.MouseDown += TopPanel_MouseDown;
            spacerFormTime.MouseMove += TopPanel_MouseMove;
            spacerFormTime.MouseUp += TopPanel_MouseUp;

            // set up component events
            secondClock.Tick += SecondClock_Tick;
            minuteClock.Tick += MinuteClock_Tick;

            exitButton.Click += ExitButton_Click;

            dateSelector.ValueChanged += DateSelector_ValueChanged;
            nextDayButton.Click += NextDayButton_Click;
            prevDayButton.Click += PrevDayButton_Click;

            dayViewButton.Click += DayViewButton_Click;
            twoDayViewButton.Click += TwoDayViewButton_Click;
            monthViewButton.Click += MonthViewButton_Click;

            createEventButton.Click += CreateEventButton_Click;
            cancelEventModifyButton.Click += CancelEventsModifyButton_Click;
            saveEventModifyButton.Click += SaveEventsModifyButton_Click;

            createCategoryButton.Click += CreateCategoryButton_Click;
            cancelCategoryModifyButton.Click += CancelCategoryEditButton_Click;
            saveCategoryModifyButton.Click += SaveCategoryEditButton_Click;

            eventsTreeView.NodeMouseClick += EventsTreeView_NodeMouseClick;
            modifyEventToolStripMenuItem.Click += ModifyEventMenuItem_Click;
            deleteEventToolStripMenuItem.Click += DeleteEventMenuItem_Click;
            modifyCategoryToolStripMenuItem.Click += ModifyCategoryMenuItem_Click;
            deleteCategoryToolStripMenuItem.Click += DeleteCategoryMenuItem_Click;

            // refresh all on-screen elements
            RefreshCalendar();
        }
        #endregion

        #region events
        /// <summary>
        /// Whether the mouse button is currently held down.</summary>
        private bool isMouseDown = false;

        /// <summary>
        /// The location of the form the last time the mouse button was held down.</summary>
        private Point formLastLocation;

        /// <summary>
        /// Registers that the mouse button has been clicked on the top panel.</summary>
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // record that user has pressed the mouse button
            isMouseDown = true;

            // record the form's current location on the screen
            formLastLocation = e.Location;
        }

        /// <summary>
        /// Registers that the mouse button has been released on the top panel.</summary>
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            // record that user has released the mouse button
            isMouseDown = false;
        }

        /// <summary>
        /// Registers that the mouse button has been moved on the top panel.</summary>
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            // if the mouse is held down, move the form
            if (isMouseDown) {
                // move the form to the location where the mouse currently is
                Location = new Point((Location.X - formLastLocation.X) + e.X, (Location.Y - formLastLocation.Y) + e.Y);

                // redraw the form
                Update();
            }
        }

        /// <summary>
        /// This function is executed every second.</summary>
        private void SecondClock_Tick(object sender, EventArgs e)
        {
            // update the clock
            UpdateClock();
        }

        /// <summary>
        /// This function is executed every minute.</summary>
        private void MinuteClock_Tick(object sender, EventArgs e)
        {
            // update the calendar view
            dailyCalendar.ChangeDate(dateSelected, todaysEvents);
        }

        /// <summary>
        /// Closes the form and exits the program.</summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Changes the currently selected date.</summary>
        private void DateSelector_ValueChanged(object sender, EventArgs e)
        {
            // change the current date
            dateSelected = dateSelector.Value.Date;

            // refresh the calendar for current date
            RefreshCalendar();
        }

        private void PrevDayButton_Click(object sender, EventArgs e)
        {
            dateSelector.Value = dateSelected.AddDays(-1);
        }

        private void NextDayButton_Click(object sender, EventArgs e)
        {
            dateSelector.Value = dateSelected.AddDays(1);
        }

        /// <summary>
        /// Changes the calendar view to a daily view.</summary>
        private void DayViewButton_Click(object sender, EventArgs e)
        {
            dayViewPanel.Visible = true;
            twoDayViewPanel.Visible = false;
            monthViewPanel.Visible = false;
        }

        /// <summary>
        /// Changes the calendar view to a two-day view.</summary>
        private void TwoDayViewButton_Click(object sender, EventArgs e)
        {
            dayViewPanel.Visible = false;
            twoDayViewPanel.Visible = true;
            monthViewPanel.Visible = false;
        }

        /// <summary>
        /// Changes the calendar view to a monthly view.</summary>
        private void MonthViewButton_Click(object sender, EventArgs e)
        {
            dayViewPanel.Visible = false;
            twoDayViewPanel.Visible = false;
            monthViewPanel.Visible = true;
        }

        /// <summary>
        /// Switches view to allow the user to create a new event.</summary>
        private void CreateEventButton_Click(object sender, EventArgs e)
        {
            currentEvent = null;

            // ensure previous inputs are cleared
            ClearEventModify();

            // set title of panel
            eventModifyLabel.Text = "Create Event";

            // switch view to event creation
            eventModifyPanel.Visible = true;
            eventsDisplayPanel.Visible = false;
            categoryModifyPanel.Visible = false;
        }

        /// <summary>
        /// Cancels the modification of an event.</summary>
        private void CancelEventsModifyButton_Click(object sender, EventArgs e)
        {
            // switch view back to events list
            eventsDisplayPanel.Visible = true;
            eventModifyPanel.Visible = false;
            categoryModifyPanel.Visible = false;
        }

        /// <summary>
        /// Verfies the event information is valid, and creates a new event if it is.</summary>
        private void SaveEventsModifyButton_Click(object sender, EventArgs e)
        {
            // check for valid input
            if (ValidateEventModify()) {
                if (currentEvent == null) {
                    // create a new event
                    CalendarEvent ev = new CalendarEvent() {
                        Label = labelField.Text,
                        Description = descriptionField.Text,
                        StartingTime = startingDate.Value.Date.AddMinutes(startingTime.Value.TimeOfDay.TotalMinutes),
                        EndingTime = endingDate.Value.Date.AddMinutes(endingTime.Value.TimeOfDay.TotalMinutes),
                        Location = new Location() {
                            Name = locationField.Text
                        },
                        Category = categoryDropDown.SelectedItem.ToString(),
                        Repetition = RecurringType.None
                    };
                    allEvents.Add(ev);

                    // insert event in the appropriate category's event list
                    CalendarCategory category;
                    if (eventCategories.TryGetValue(ev.Category, out category)) {
                        category.Events.Add(ev);
                    }
                } else {
                    // remove event from its old category
                    CalendarCategory category;
                    if (eventCategories.TryGetValue(currentEvent.Category, out category)) {
                        category.Events.Remove(currentEvent);
                    }

                    // update event
                    currentEvent.Label = labelField.Text;
                    currentEvent.Description = descriptionField.Text;
                    currentEvent.StartingTime = startingDate.Value.Date.AddMinutes(startingTime.Value.TimeOfDay.TotalMinutes);
                    currentEvent.EndingTime = endingDate.Value.Date.AddMinutes(endingTime.Value.TimeOfDay.TotalMinutes);
                    currentEvent.Location = new Location() {
                        Name = locationField.Text
                    };
                    currentEvent.Category = categoryDropDown.SelectedItem.ToString();
                    currentEvent.Repetition = RecurringType.None;

                    // insert event into its new category
                    if (eventCategories.TryGetValue(currentEvent.Category, out category)) {
                        category.Events.Add(currentEvent);
                    }
                }

                // refresh the calendar
                RefreshCalendar();

                // switch view back to events list
                eventsDisplayPanel.Visible = true;
                eventModifyPanel.Visible = false;
                categoryModifyPanel.Visible = false;
            }
        }

        /// <summary>
        /// Cancels the modification of an event.</summary>
        private void CreateCategoryButton_Click(object sender, EventArgs e)
        {
            // ensure previous inputs are cleared
            ClearCategoryModify();

            // switch view back to events list
            categoryModifyPanel.Visible = true;
            eventsDisplayPanel.Visible = false;
            eventModifyPanel.Visible = false;
        }

        /// <summary>
        /// Cancels the modification of a category.</summary>
        private void CancelCategoryEditButton_Click(object sender, EventArgs e)
        {
            // switch view back to events list
            eventsDisplayPanel.Visible = true;
            eventModifyPanel.Visible = false;
            categoryModifyPanel.Visible = false;
        }

        /// <summary>
        /// Verfies the category information is valid, and creates a new category if it is.</summary>
        private void SaveCategoryEditButton_Click(object sender, EventArgs e)
        {
            // check for valid input
            if (ValidateCategoryModify()) {
                // switch view back to events list
                eventsDisplayPanel.Visible = true;
                eventModifyPanel.Visible = false;
                categoryModifyPanel.Visible = false;
            }
        }

        /// <summary>
        /// Sets behaviour where right-clicking a tree node will also set it as being selected.</summary>
        private void EventsTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // make right-clicks on tree nodes set them as selected
            if (e.Button == MouseButtons.Right) {
                eventsTreeView.SelectedNode = e.Node;
            }
        }

        /// <summary>
        /// Takes the user to the event modification panel for the selected event.</summary>
        private void ModifyEventMenuItem_Click(object sender, EventArgs e)
        {
            // get the selected event
            TreeNode parentNode = (((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as TreeView).SelectedNode;
            currentEvent = parentNode.Tag as CalendarEvent;

            // ensure previous inputs are cleared
            ClearEventModify();

            // set title of panel
            eventModifyLabel.Text = "Modify Event";

            // fill in event details in controls
            labelField.Text = currentEvent.Label;
            startingDate.Value = currentEvent.StartingTime.Date;
            startingTime.Value = currentEvent.StartingTime;
            endingDate.Value = currentEvent.EndingTime.Date;
            endingTime.Value = currentEvent.EndingTime;
            categoryDropDown.SelectedIndex = categoryDropDown.FindStringExact(currentEvent.Category);
            locationField.Text = currentEvent.Location.Name;
            descriptionField.Text = currentEvent.Description;

            // switch view to events modification
            eventModifyPanel.Visible = true;
            eventsDisplayPanel.Visible = false;
            categoryModifyPanel.Visible = false;
        }

        /// <summary>
        /// Shows a confirmation before allowing the user to delete the selected event.</summary>
        private void DeleteEventMenuItem_Click(object sender, EventArgs e)
        {
            // get the selected event
            TreeNode parentNode = (((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as TreeView).SelectedNode;
            currentEvent = parentNode.Tag as CalendarEvent;

            // create a string with event data
            string checkString = currentEvent.Label + "\r\n"
                + currentEvent.StartingTime.ToString() + " - " + currentEvent.EndingTime.ToString() + "\r\n"
                + "Category: " + currentEvent.Category + "\r\n"
                + "Location: " + currentEvent.Location.Name + "\r\n"
                + "Description: " + currentEvent.Description;

            // show a confirmation dialog to user before deleting event
            DialogResult check = MessageBox.Show("Are you sure you wish to delete this event?\r\n\r\n" + checkString, "Delete Event", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes) {
                // delete the event
                allEvents.Remove(currentEvent);
                CalendarCategory category;
                if (eventCategories.TryGetValue(currentEvent.Category, out category)) {
                    category.Events.Remove(currentEvent);
                }

                // refresh the form
                RefreshCalendar();
            }
        }

        /// <summary>
        /// Takes the user to the category modification panel for the selected category.</summary>
        private void ModifyCategoryMenuItem_Click(object sender, EventArgs e)
        {
            // get the selected category
            TreeNode parentNode = (((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as TreeView).SelectedNode;
            CalendarCategory selectedEvent = parentNode.Tag as CalendarCategory;

            // TODO: Edit Category
        }

        /// <summary>
        /// Shows a confirmation before allowing the user to delete the selected category.</summary>
        private void DeleteCategoryMenuItem_Click(object sender, EventArgs e)
        {
            // get the selected category
            TreeNode parentNode = (((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as TreeView).SelectedNode;
            CalendarCategory selectedEvent = parentNode.Tag as CalendarCategory;

            // TODO: Delete Category
        }
        #endregion

        #region miscellaneous
        /// <summary>
        /// Refreshes the calendar view and the events list.</summary>
        private void RefreshCalendar()
        {
            // today's event include all events from 12 AM of today's date to 12 AM of tomorrow's date
            todaysEvents = allEvents.GetViewBetween(new CalendarEvent() { StartingTime = dateSelected }, new CalendarEvent() { StartingTime = dateSelected.AddDays(1) });

            // refresh the events list
            refreshTree(dateSelected);

            // refresh the calendar view
            dailyCalendar.ChangeDate(dateSelected, todaysEvents);
        }

        /// <summary>
        /// Updates the clock that's on the top of the form.</summary>
        private void UpdateClock()
        {
            currentTimeDisplay.Text = DateTime.Now.ToString("h:mm tt", CultureInfo.InvariantCulture);
        }

        private void loadEventsFromFile(string filename, out Dictionary<string, CalendarCategory> categories, out SortedSet<CalendarEvent> events)
        {
            //FOR NOW WE JUST CREATE IT MANUALLY, WE WILL HAVE TO GET FROM FILE LATER..*******
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            // dummy categories
            CalendarCategory cat2 = new CalendarCategory() {
                Name = "Work",
                Symbol = Shape.Triangle,
                Colour = Color.Red
            };
            CalendarCategory cat3 = new CalendarCategory() {
                Name = "Soccer",
                Symbol = Shape.Circle,
                Colour = Color.Purple
            };
            CalendarCategory cat4 = new CalendarCategory() {
                Name = "Other",
                Symbol = Shape.Star,
                Colour = Color.Green
            };

            // dummy events
            CalendarEvent testEventA = new CalendarEvent() {
                Label = "TestEvent_A",
                Description = "This is TestEvent_A",
                StartingTime = DateTime.Today.AddHours(9),
                EndingTime = DateTime.Today.AddHours(17),
                Location = new Location() {
                    Name = "Western University"
                },
                Category = cat2.Name,
                Repetition = RecurringType.None
            };
            CalendarEvent testEventB = new CalendarEvent() {
                Label = "TestEvent_B",
                Description = "This is TestEvent_B",
                StartingTime = DateTime.Today.AddHours(12),
                EndingTime = DateTime.Today.AddHours(13).AddMinutes(30),
                Location = new Location() {
                    Name = "Western University"
                },
                Category = cat2.Name,
                Repetition = RecurringType.None
            };
            CalendarEvent testEventC = new CalendarEvent() {
                Label = "TestEvent_C",
                Description = "This is TestEvent_C",
                StartingTime = DateTime.Today.AddHours(18),
                EndingTime = DateTime.Today.AddHours(20).AddMinutes(45),
                Location = new Location() {
                    Name = "Western University"
                },
                Category = cat3.Name,
                Repetition = RecurringType.None
            };
            CalendarEvent testEventD = new CalendarEvent() {
                Label = "TestEvent_D",
                Description = "This is TestEvent_D",
                StartingTime = DateTime.Today.AddHours(22),
                EndingTime = DateTime.Today.AddHours(30),
                Location = new Location() {
                    Name = "Home"
                },
                Category = cat4.Name,
                Repetition = RecurringType.None
            };
            CalendarEvent testEventE = new CalendarEvent() {
                Label = "TestEvent_E",
                Description = "This is TestEvent_E",
                StartingTime = DateTime.Today.AddDays(1).AddHours(9),
                EndingTime = DateTime.Today.AddDays(1).AddHours(17),
                Location = new Location() {
                    Name = "Western University"
                },
                Category = cat2.Name,
                Repetition = RecurringType.None
            };

            // create references to events in categories
            cat2.Events.Add(testEventA);
            cat2.Events.Add(testEventB);
            cat3.Events.Add(testEventC);
            cat4.Events.Add(testEventD);
            cat2.Events.Add(testEventE);

            events = new SortedSet<CalendarEvent>(new SortEventsByDate());
            events.Add(testEventA);
            events.Add(testEventB);
            events.Add(testEventC);
            events.Add(testEventD);
            events.Add(testEventE);

            categories = new Dictionary<string, CalendarCategory>();
            categories.Add(cat2.Name, cat2);
            categories.Add(cat3.Name, cat3);
            categories.Add(cat4.Name, cat4);
        }

        public void refreshTree(DateTime date)
        {
            // define the fonts used in the tree view
            Font treeCategoryFont = new Font("Tw Cen MT", 14.25F);
            Font treeEventFont = new Font("Tw Cen MT Condensed", 11.25F, FontStyle.Bold);

            // clear out tree view
            eventsTreeView.Nodes.Clear();

            //Initialize the tree's 'All events' sections
            string nodeImg = "bluSq.png";
            TreeNode node = new TreeNode() {
                ForeColor = Color.White,
                ImageKey = nodeImg,
                NodeFont = treeCategoryFont,
                SelectedImageKey = nodeImg,
                Text = "All                            "
            };
            eventsTreeView.Nodes.Add(node);

            //Add all events to the 'all' node
            foreach (CalendarEvent ev in todaysEvents) {
                eventsTreeView.Nodes[0].Nodes.Add(new TreeNode() {
                    ContextMenuStrip = eventContextMenu,
                    ForeColor = Color.White,
                    ImageKey = "whtDot.png",
                    NodeFont = treeEventFont,
                    SelectedImageKey = "whtDot.png",
                    Tag = ev,
                    Text = ev.StartingTime.ToString("MMM dd (h:mmtt) - ") + ev.Label + "                            "
                });
            }

            // create a tree node for each category
            foreach (CalendarCategory category in eventCategories.Values) {
                // determine the correct symbol to use
                nodeImg = null;
                if (category.Symbol == Shape.Circle && category.Colour == Color.Purple) nodeImg = "purCirc.png";
                else if (category.Symbol == Shape.Star && category.Colour == Color.Green) nodeImg = "grStar.png";
                else if (category.Symbol == Shape.Square && category.Colour == Color.Blue) nodeImg = "bluSq.png";
                else if (category.Symbol == Shape.Triangle && category.Colour == Color.Red) nodeImg = "redTri.png";

                // create the category tree node
                node = new TreeNode() {
                    ContextMenuStrip = categoryContextMenu,
                    ForeColor = Color.White,
                    ImageKey = nodeImg,
                    NodeFont = treeCategoryFont,
                    SelectedImageKey = nodeImg,
                    Tag = category,
                    Text = category.Name + "                            "
                };

                // add all of today's event under this category as children of the category tree node
                foreach (CalendarEvent ev in todaysEvents.Where((ev) => { return ev.Category == category.Name; })) {
                    node.Nodes.Add(new TreeNode() {
                        ContextMenuStrip = eventContextMenu,
                        ForeColor = Color.White,
                        ImageKey = "whtDot.png",
                        NodeFont = treeEventFont,
                        SelectedImageKey = "whtDot.png",
                        Tag = ev,
                        Text = ev.StartingTime.ToString("MMM dd (h:mmtt) - ") + ev.Label + "                            "
                    });
                }

                // add category node to tree view
                eventsTreeView.Nodes.Add(node);
            }

            //Initialize the tree's primary nodes
            /*foreach (CalendarCategory cat in todaysEvents.Keys) {
                TreeNode node = new TreeNode(cat.Name + "                            ");
                if (cat.Symbol == Shape.Circle && cat.Colour == Color.Purple) node.ImageKey = node.SelectedImageKey = "purCirc.png";
                else if (cat.Symbol == Shape.Star && cat.Colour == Color.Green) node.ImageKey = node.SelectedImageKey = "grStar.png";
                else if (cat.Symbol == Shape.Square && cat.Colour == Color.Blue) node.ImageKey = node.SelectedImageKey = "bluSq.png";
                else if (cat.Symbol == Shape.Triangle && cat.Colour == Color.Red) node.ImageKey = node.SelectedImageKey = "redTri.png";

                node.ForeColor = Color.White;
                node.NodeFont = new Font(new FontFamily("Tw Cen MT"), 14.25f, FontStyle.Regular);

                List<CalendarEvent> orderedEvents = todaysEvents[cat].OrderBy(a => a.StartingTime).ToList();
                foreach (CalendarEvent ev in todaysEvents[cat]) {
                    allEventsToday.Add(ev);
                    TreeNode child = new TreeNode(ev.StartingTime.ToString("MMM dd (h:mmtt) - ") + ev.Label + "                            ");
                    child.ImageKey = child.SelectedImageKey = "whtDot.png";
                    child.ForeColor = Color.White;
                    child.NodeFont = new Font(new FontFamily("Tw Cen MT Condensed"), 11.25f, FontStyle.Bold);

                    node.Nodes.Add(child);
                }

                this.eventsTreeView.Nodes.Add(node);
            }*/
        }

        /// <summary>
        /// Clears the event modification panel of all input.</summary>
        private void ClearEventModify()
        {
            // reset text boxes
            labelField.Text = string.Empty;
            locationField.Text = string.Empty;
            descriptionField.Text = string.Empty;

            // reset date pickers
            startingDate.Value = DateTime.Now;
            startingTime.Value = DateTime.Now;
            endingDate.Value = DateTime.Now;
            endingTime.Value = DateTime.Now;

            // reset category drop downs
            categoryDropDown.Items.Clear();
            categoryDropDown.Items.Add("Uncategorized");
            categoryDropDown.Items.AddRange(eventCategories.Keys.ToArray());

            // reset errors field
            eventErrors.Clear();
        }

        /// <summary>
        /// Verifies that the event information the user has entered is valid.</summary>
        /// <returns>True if the event is valid, false otherwise.</returns>
        private bool ValidateEventModify()
        {
            bool isValidEvent = true;
            List<string> errors = new List<string>();

            // check that the label field in not empty
            if (string.IsNullOrWhiteSpace(labelField.Text)) {
                errors.Add("Error: Event label cannot be empty");
                isValidEvent = false;
            }

            // check that a category for the event has been selected
            if (string.IsNullOrWhiteSpace(categoryDropDown.Text)) {
                errors.Add("Error: Event must be assigned a category");
                isValidEvent = false;
            }

            DateTime startTime = startingDate.Value.Date.AddMinutes(startingTime.Value.TimeOfDay.TotalMinutes);
            DateTime endTime = endingDate.Value.Date.AddMinutes(endingTime.Value.TimeOfDay.TotalMinutes);
            if (startTime > endTime) {
                errors.Add("Error: The end date for the event must come after the start date");
                isValidEvent = false;
            }

            // write errors to output
            eventErrors.Clear();
            if (errors.Count >= 0) {
                eventErrors.Text += "Please resolve the following errors:";

                foreach (string err in errors) {
                    eventErrors.Text += "\r\n  " + err;
                }
            }

            return isValidEvent;
        }

        private void ClearCategoryModify()
        {
        }

        /// <summary>
        /// Verifies that the category information the user has entered is valid.</summary>
        /// <returns>True if the category is valid, false otherwise.</returns>
        private bool ValidateCategoryModify()
        {
            return true;
        }
        #endregion
    }
}
