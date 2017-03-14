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
        DateTime dateSelected;
        Dictionary<DateTime, List<CalendarEvent>> eventsCollection = new Dictionary<DateTime, List<CalendarEvent>>();

        #region initialization
        public Form1()
        {
            InitializeComponent();

            dateSelected = DateTime.Today;
            refreshDateFields(dateSelected);

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
            dateSelected = this.datePicker1.Value;
            refreshDateFields(dateSelected);
        }

        private void PrevDayButton_Click(object sender, EventArgs e)
        {
            dateSelected = dateSelected.AddDays(-1);
            refreshDateFields(dateSelected);
        }

        private void NextDayButton_Click(object sender, EventArgs e)
        {
            dateSelected = dateSelected.AddDays(1);
            refreshDateFields(dateSelected);
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

        #endregion

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
    }
}
