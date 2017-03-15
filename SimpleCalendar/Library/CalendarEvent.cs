using System;

namespace SimpleCalendar
{
    /// <summary>
    /// An event is a scheduled time that has been recorded in the calendar service.</summary>
    public class CalendarEvent
    {
        /// <summary>
        /// The name of the event.</summary>
        public string Label;

        /// <summary>
        /// A textual description of the event.</summary>
        public string Description;

        /// <summary>
        /// The time which the event starts.</summary>
        public DateTime StartingTime;

        /// <summary>
        /// The time which the event ends.</summary>
        public DateTime EndingTime;

        /// <summary>
        /// The venue of the event.</summary>
        public Location Location;

        /// <summary>
        /// The name of the category in which the event is assigned.</summary>
        public string Category;

        /// <summary>
        /// The type of recurrence the event has.</summary>
        public RecurringType Repetition;
    }

    public enum RecurringType
    {
        Daily,
        Weekly,
        Monthly,
        Yearly,
        None
    };
}
