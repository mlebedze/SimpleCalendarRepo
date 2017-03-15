using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCalendar
{

    public partial class Form1 : Form
    {
        public DateTime dateSelected = DateTime.Today;
        //public Dictionary<DateTime, Dictionary<CalendarCategory, List<CalendarEvent>>> eventsCollection = new Dictionary<DateTime, Dictionary<CalendarCategory, List<CalendarEvent>>>();

        private Dictionary<string, CalendarCategory> eventCategories;
        private SortedSet<CalendarEvent> allEvents;

        private SortedSet<CalendarEvent> todaysEvents;

        #region initialization
        public Form1()
        {
            InitializeComponent();

            //Initial categories until we get a read file set up
            loadEventsFromFile(out eventCategories, out allEvents);
            RefreshCalendar();

            //Button interactions
            this.createEventButton.Click += CreateEventButton_Click;
            this.createCategoryButton.Click += CreateCategoryButton_Click;

            this.cancelEventsEditButton.Click += CancelEventsEditButton_Click;
            this.saveEventsEditButton.Click += SaveEventsEditButton_Click;

            this.cancelCategoryEditButton.Click += CancelCategoryEditButton_Click;
            this.saveCategoryEditButton.Click += SaveCategoryEditButton_Click;

            this.exitButton.Click += ExitButton_Click;

            this.datePicker1.ValueChanged += DatePicker1_ValueChanged;

            this.nextDayButton.Click += NextDayButton_Click;
            this.prevDayButton.Click += PrevDayButton_Click;
        }
        #endregion

        private void RefreshCalendar()
        {
            todaysEvents = allEvents.GetViewBetween(new CalendarEvent() { StartingTime = dateSelected }, new CalendarEvent() { StartingTime = dateSelected.AddDays(1) });

            refreshTree(dateSelected);
            refreshDateFields(dateSelected);
            dailyCalendar1.ChangeDate(dateSelected, todaysEvents);
        }

        #region events
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatePicker1_ValueChanged(object sender, EventArgs e)
        {
            // change the current date
            dateSelected = datePicker1.Value.Date;

            // refresh the calendar for current date
            RefreshCalendar();
        }

        private void PrevDayButton_Click(object sender, EventArgs e)
        {
            datePicker1.Value = dateSelected.AddDays(-1);
        }

        private void NextDayButton_Click(object sender, EventArgs e)
        {
            datePicker1.Value = dateSelected.AddDays(1);
        }

        private void SaveCategoryEditButton_Click(object sender, EventArgs e)
        {
            this.eventsDisplayPanel.Visible = true;
            this.categoryEditPanel.Visible = false;
            this.createEventPanel.Visible = false;
        }

        private void CancelCategoryEditButton_Click(object sender, EventArgs e)
        {
            this.eventsDisplayPanel.Visible = true;
            this.categoryEditPanel.Visible = false;
            this.createEventPanel.Visible = false;
        }

        private void SaveEventsEditButton_Click(object sender, EventArgs e)
        {
            this.eventsDisplayPanel.Visible = true;
            this.categoryEditPanel.Visible = false;
            this.createEventPanel.Visible = false;
        }

        private void CancelEventsEditButton_Click(object sender, EventArgs e)
        {
            this.eventsDisplayPanel.Visible = true;
            this.categoryEditPanel.Visible = false;
            this.createEventPanel.Visible = false;
        }

        private void CreateCategoryButton_Click(object sender, EventArgs e)
        {
            this.eventsDisplayPanel.Visible = false;
            this.categoryEditPanel.Visible = true;
            this.createEventPanel.Visible = false;
        }

        private void CreateEventButton_Click(object sender, EventArgs e)
        {
            this.eventsDisplayPanel.Visible = false;
            this.categoryEditPanel.Visible = false;
            this.createEventPanel.Visible = true;
        }
        #endregion

        #region miscellaneous
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private const int WM_NCHITTEST = 0x84;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST) {
                m.Result = (IntPtr) (HT_CAPTION);
            }
        }

        private void refreshDateFields(DateTime date)
        {
            //this.selectedDateDisplay.Text = dateSelected.ToString("MMMM d, yyyy");
            currentTimeDisplay.Text = DateTime.Now.ToString("h:mm tt", CultureInfo.InvariantCulture);

            //this.calendarPartTodayDisp1.Text = date.ToString("dddd") + ",";
            //this.calendarPartTodayDisp2.Text = date.ToString("MMMM d");

            //this.calendarPartTmrDisp1.Text = date.AddDays(1).ToString("dddd") + ",";
            //this.calendarPartTmrDisp2.Text = date.AddDays(1).ToString("MMMM d");
        }

        private void loadEventsFromFile(out Dictionary<string, CalendarCategory> categories, out SortedSet<CalendarEvent> events)
        {
            //FOR NOW WE JUST CREATE IT MANUALLY, WE WILL HAVE TO GET FROM FILE LATER..*******
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            //eventsCollection = new Dictionary<DateTime, Dictionary<CalendarCategory, List<CalendarEvent>>>();
            //Dictionary<CalendarCategory, List<CalendarEvent>> todayTemp = new Dictionary<CalendarCategory, List<CalendarEvent>>();

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

            /*List<CalendarEvent> calEvents = new List<CalendarEvent>();
            calEvents.Add(testEventA);
            calEvents.Add(testEventB);
            calEvents.Add(testEventC);
            calEvents.Add(testEventD);
            calEvents.Add(testEventE);

            todayTemp.Add(cat2, calEvents);
            todayTemp.Add(cat3, calEvents);
            todayTemp.Add(cat4, calEvents);

            eventsCollection.Add(DateTime.Today, todayTemp);*/
        }

        public void refreshTree(DateTime date)
        {
            // clear out tree view
            this.eventsTreeView.Nodes.Clear();

            /*Dictionary<CalendarCategory, List<CalendarEvent>> todaysEvents = new Dictionary<CalendarCategory, List<CalendarEvent>>();
            if (eventsCollection.ContainsKey(date)) todaysEvents = eventsCollection[date];*/

            //Initialize the tree's 'All events' sections
            TreeNode nodeAll = new TreeNode("All                            ");
            nodeAll.ImageKey = nodeAll.SelectedImageKey = "bluSq.png";
            nodeAll.ForeColor = Color.White;
            nodeAll.NodeFont = new Font(new FontFamily("Tw Cen MT"), 14.25f, FontStyle.Regular);
            this.eventsTreeView.Nodes.Add(nodeAll);

            //List<CalendarEvent> allEventsToday = new List<CalendarEvent>();

            foreach (CalendarCategory category in eventCategories.Values) {
                string nodeImg = null;
                if (category.Symbol == Shape.Circle && category.Colour == Color.Purple) nodeImg = "purCirc.png";
                else if (category.Symbol == Shape.Star && category.Colour == Color.Green) nodeImg = "grStar.png";
                else if (category.Symbol == Shape.Square && category.Colour == Color.Blue) nodeImg = "bluSq.png";
                else if (category.Symbol == Shape.Triangle && category.Colour == Color.Red) nodeImg = "redTri.png";

                TreeNode node = new TreeNode() {
                    ForeColor = Color.White,
                    ImageKey = nodeImg,
                    NodeFont = new Font(new FontFamily("Tw Cen MT"), 14.25f, FontStyle.Regular),
                    SelectedImageKey = nodeImg,
                    Text = category.Name + "                            "
                };

                foreach (CalendarEvent ev in this.todaysEvents.Where((ev) => { return ev.Category == category.Name; })) {
                    TreeNode child = new TreeNode(ev.StartingTime.ToString("MMM dd (h:mmtt) - ") + ev.Label + "                            ");
                    child.ImageKey = child.SelectedImageKey = "whtDot.png";
                    child.ForeColor = Color.White;
                    child.NodeFont = new Font(new FontFamily("Tw Cen MT Condensed"), 11.25f, FontStyle.Bold);

                    node.Nodes.Add(child);
                }

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

            //Add all events to the 'all' node
            foreach (CalendarEvent ev in this.todaysEvents) {
                TreeNode child = new TreeNode(ev.StartingTime.ToString("MMM dd (h:mmtt) - ") + ev.Label + "                            ");
                child.ImageKey = child.SelectedImageKey = "whtDot.png";
                child.ForeColor = Color.White;
                child.NodeFont = new Font(new FontFamily("Tw Cen MT Condensed"), 11.25f, FontStyle.Bold);
                this.eventsTreeView.Nodes[0].Nodes.Add(child);
            }
        }
        #endregion

        private void dayViewButton_Click(object sender, EventArgs e)
        {
            dayViewPanel.Visible = true;
        }

        private void monthViewButton_Click(object sender, EventArgs e)
        {
            dayViewPanel.Visible = false;
        }

        private void currentTimeDisplay_Click(object sender, EventArgs e)
        {
            datePicker1.Value = DateTime.Today;
        }
    }
}
