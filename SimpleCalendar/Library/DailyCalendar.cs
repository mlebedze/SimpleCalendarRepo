using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace SimpleCalendar
{
    /// <summary>
    /// Provides a view for events on a single calendar day.</summary>
    public partial class DailyCalendar : UserControl
    {
        /// <summary>
        /// The date which is currently represented on the calendar.</summary>
        private DateTime currentDate;

        /// <summary>
        /// The events which are currently represented on the calendar.</summary>
        private List<CalendarEvent> currentEvents;

        /// <summary>
        /// All user-created event categories.</summary>
        private Dictionary<string, CalendarCategory> userCategories;

        private PrivateFontCollection pfc;

        /// <summary>
        /// Creates the <c>DailyCalendar</c> control.</summary>
        public DailyCalendar()
        {
            pfc = new PrivateFontCollection();
            pfc.AddFontFile("Tw Cen MT RESOURCE.ttf");
            currentDate = DateTime.Today;
            currentEvents = new List<CalendarEvent>();

            InitializeComponent();
        }

        /// <summary>
        /// Changes the represented date on the calendar.</summary>
        /// <param name="newDate">The new date to represent.</param>
        /// <param name="events">The new events to represent.</param>
        /// <param name="categories">The categories that the user has defined.</param>
        public void ChangeDate(DateTime newDate, List<CalendarEvent> events, Dictionary<string, CalendarCategory> categories)
        {
            // change the current represented date
            currentDate = newDate;
            currentEvents = events;
            userCategories = categories;

            // invalidate the control and repaint calendar
            Invalidate();
        }

        /// <summary>
        /// Raises the <c>Paint</c> event.</summary>
        /// <param name="e">A <c>PaintEventArgs</c> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            // draws the background grid for the calendar
            DrawGrid(e);

            // draws the events on the calendar
            DrawEvents(e);

            // draw the line for the current time on the calendar
            DrawTimeLine(e);
        }

        /// <summary>
        /// Draws the background grid for the calendar.</summary>
        /// <param name="e">A <c>PaintEventArgs</c> that contains the event data.</param>
        private void DrawGrid(PaintEventArgs e)
        {
            // define grid style
            Color gridColour = Color.FromArgb(255, 52, 73, 94);
            Font gridFont = new Font(pfc.Families[0], 9, FontStyle.Italic);

            // create drawing tools
            Pen pen = new Pen(gridColour, 2F);
            Brush brush = new SolidBrush(gridColour);

            // draw hour lines
            float x = 0F;
            float step = Width / 24F;
            for (int hour = 0; hour <= 24; hour++) {
                // draw hour line
                e.Graphics.DrawLine(pen, x, 0F, x, Height);

                // draw hour label
                if (hour < 12) {
                    e.Graphics.DrawString(hour == 0 ? "12" : hour.ToString(), gridFont, brush, x + 0.5F, 0F);
                } else {
                    e.Graphics.DrawString(hour == 12 ? "12" : (hour - 12).ToString(), gridFont, brush, x + 0.5F, Height - 18F);
                }

                // increase step
                x += step;
            }
        }

        /// <summary>
        /// Draws the user's events on the calendar.</summary>
        /// <param name="e">A <c>PaintEventArgs</c> that contains the event data.</param>
        private void DrawEvents(PaintEventArgs e)
        {
            int eventIndex = 0;

            float intialY = 32F;
            float yStep = 10F;
            float minutes, startX, endX;

            // draw all the events on the calendar
            foreach (CalendarEvent ev in currentEvents) {
                // determine where on the calendar to start the line
                minutes = Convert.ToSingle((ev.StartingTime - currentDate).TotalMinutes);
                startX = (minutes * Width) / 1440F;

                // determine where on the calendar to end the line
                minutes = Convert.ToSingle((ev.EndingTime - currentDate).TotalMinutes);
                endX = (minutes * Width) / 1440F;

                // draw the line
                e.Graphics.DrawLine(new Pen(userCategories[ev.Category].Colour, 8F), startX, intialY + eventIndex * yStep, endX, intialY + eventIndex * yStep);

                eventIndex++;
            }
        }

        /// <summary>
        /// Draws the line for the current time on the calendar.</summary>
        /// <param name="e">A <c>PaintEventArgs</c> that contains the event data.</param>
        private void DrawTimeLine(PaintEventArgs e)
        {
            // only draw time line if the current date is today's date
            if (currentDate != DateTime.Today) {
                return;
            }

            // determine where on the calendar to draw the line
            float minutes = Convert.ToSingle((DateTime.Now - DateTime.Today).TotalMinutes);
            float x = (minutes * Width) / 1440F;

            // draw the line for the current time
            e.Graphics.DrawLine(new Pen(Color.FromArgb(255, 39, 174, 96), 2F), x, 0F, x, Height);
        }
    }
}
