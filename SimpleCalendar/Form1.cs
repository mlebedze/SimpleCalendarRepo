using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalendar
{
    public partial class Form1 : Form
    {
        public DateTime dateSelected = DateTime.Today;
        public Dictionary<DateTime, Dictionary<CalendarCategory, List<CalendarEvent>>> eventsCollection = new Dictionary<DateTime, Dictionary<CalendarCategory, List<CalendarEvent>>>();

        #region initialization
        public Form1()
        {
            InitializeComponent();

            dateSelected = DateTime.Today;
            refreshDateFields(dateSelected);

            //Initial categories until we get a read file set up

            loadEventsFromFile(out eventsCollection);
            refreshTree(dateSelected);

            //On the left hand side of the screen, initialize to show the events panel
            this.eventsDisplayPanel.Dock = DockStyle.Fill;
            this.categoryEditPanel.Dock = DockStyle.Fill;
            this.createEventPanel.Dock = DockStyle.Fill;

            this.eventsDisplayPanel.Visible = true;
            this.categoryEditPanel.Visible = false;
            this.createEventPanel.Visible = false;

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

        #region events

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateSelected = this.datePicker1.Value.Date;
            refreshDateFields(dateSelected);
            refreshTree(dateSelected);
        }

        private void PrevDayButton_Click(object sender, EventArgs e)
        {
            dateSelected = dateSelected.AddDays(-1);
            refreshDateFields(dateSelected);
            refreshTree(dateSelected);
        }

        private void NextDayButton_Click(object sender, EventArgs e)
        {
            dateSelected = dateSelected.AddDays(1);
            refreshDateFields(dateSelected);
            refreshTree(dateSelected);
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

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void refreshDateFields(DateTime date)
        {
            this.selectedDateDisplay.Text = dateSelected.ToString("MMMM d, yyyy");
            currentTimeDisplay.Text = DateTime.Now.ToString("h:mm tt", CultureInfo.InvariantCulture);

            this.calendarPartTodayDisp1.Text = date.ToString("dddd") + ",";
            this.calendarPartTodayDisp2.Text = date.ToString("MMMM d");

            this.calendarPartTmrDisp1.Text = date.AddDays(1).ToString("dddd") + ",";
            this.calendarPartTmrDisp2.Text = date.AddDays(1).ToString("MMMM d");
        }

        private void loadEventsFromFile(out Dictionary<DateTime, Dictionary<CalendarCategory, List<CalendarEvent>>> eventsCollection)
        {
            //FOR NOW WE JUST CREATE IT MANUALLY, WE WILL HAVE TO GET FROM FILE LATER..*******
            //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            eventsCollection = new Dictionary<DateTime, Dictionary<CalendarCategory, List<CalendarEvent>>>();

            Dictionary<CalendarCategory, List<CalendarEvent>> todayTemp = new Dictionary<CalendarCategory, List<CalendarEvent>>();
            List<CalendarCategory> categories = new List<CalendarCategory>();
            CalendarCategory cat2 = new CalendarCategory();
            cat2.color = Color.Red;
            cat2.name = "Work";
            cat2.symbol = Shape.Triangle;
            categories.Add(cat2);
            CalendarCategory cat3 = new CalendarCategory();
            cat3.color = Color.Purple;
            cat3.name = "Soccer";
            cat3.symbol = Shape.Circle;
            categories.Add(cat3);
            CalendarCategory cat4 = new CalendarCategory();
            cat4.color = Color.Green;
            cat4.name = "Other";
            cat4.symbol = Shape.Star;
            categories.Add(cat4);

            CalendarEvent someGenericEvent = new CalendarEvent();
            someGenericEvent.title = "test";
            someGenericEvent.description = "something";
            someGenericEvent.start = DateTime.Now;
            someGenericEvent.end = DateTime.Now.AddHours(3);
            someGenericEvent.recurring = RecurringType.None;
            someGenericEvent.location = "?";

            List<CalendarEvent> calEvents = new List<CalendarEvent>();
            calEvents.Add(someGenericEvent);

            todayTemp.Add(cat2, calEvents);
            todayTemp.Add(cat3, calEvents);
            todayTemp.Add(cat4, calEvents);

            eventsCollection.Add(DateTime.Today, todayTemp);
        }

        public void refreshTree(DateTime date)
        {
            this.eventsTreeView.Nodes.Clear();

            Dictionary<CalendarCategory, List<CalendarEvent>> todaysEvents = new Dictionary<CalendarCategory, List<CalendarEvent>>();
            if (eventsCollection.ContainsKey(date)) todaysEvents = eventsCollection[date];

            //Initialize the tree's 'All events' sections
            TreeNode nodeAll = new TreeNode("All                            ");
            nodeAll.ImageKey = nodeAll.SelectedImageKey = "bluSq.png";
            nodeAll.ForeColor = Color.White;
            nodeAll.NodeFont = new Font(new FontFamily("Tw Cen MT"), 14.25f, FontStyle.Regular);
            this.eventsTreeView.Nodes.Add(nodeAll);

            List<CalendarEvent> allEventsToday = new List<CalendarEvent>();

            //Initialize the tree's primary nodes
            foreach (CalendarCategory cat in todaysEvents.Keys)
            {
                TreeNode node = new TreeNode(cat.name + "                            ");
                if (cat.symbol == Shape.Circle && cat.color == Color.Purple) node.ImageKey = node.SelectedImageKey = "purCirc.png";
                else if (cat.symbol == Shape.Star && cat.color == Color.Green) node.ImageKey = node.SelectedImageKey = "grStar.png";
                else if (cat.symbol == Shape.Square && cat.color == Color.Blue) node.ImageKey = node.SelectedImageKey = "bluSq.png";
                else if (cat.symbol == Shape.Triangle && cat.color == Color.Red) node.ImageKey = node.SelectedImageKey = "redTri.png";

                node.ForeColor = Color.White;
                node.NodeFont = new Font(new FontFamily("Tw Cen MT"), 14.25f, FontStyle.Regular);

                List<CalendarEvent> orderedEvents = todaysEvents[cat].OrderBy(a => a.start).ToList();
                foreach (CalendarEvent ev in todaysEvents[cat])
                {
                    allEventsToday.Add(ev);
                    TreeNode child = new TreeNode(ev.start.ToString("MMM dd (h:mmtt) - ") + ev.title + "                            ");
                    child.ImageKey = child.SelectedImageKey = "whtDot.png";
                    child.ForeColor = Color.White;
                    child.NodeFont = new Font(new FontFamily("Tw Cen MT Condensed"), 11.25f, FontStyle.Bold);

                    node.Nodes.Add(child);
                }

                this.eventsTreeView.Nodes.Add(node);
            }

            //Add all events to the 'all' node
            foreach (CalendarEvent ev in allEventsToday.OrderBy(a=>a.start))
            {
                TreeNode child = new TreeNode(ev.start.ToString("MMM dd (h:mmtt) - ") + ev.title + "                            ");
                child.ImageKey = child.SelectedImageKey = "whtDot.png";
                child.ForeColor = Color.White;
                child.NodeFont = new Font(new FontFamily("Tw Cen MT Condensed"), 11.25f, FontStyle.Bold);
                this.eventsTreeView.Nodes[0].Nodes.Add(child);
            }
        }

        #endregion

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
    }
}
