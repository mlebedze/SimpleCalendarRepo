using System.Collections.Generic;
using System.Drawing;

namespace SimpleCalendar
{
    /// <summary>
    /// A category is a user-defined classification for events.</summary>
    public class CalendarCategory
    {
        /// <summary>
        /// The name of the category.</summary>
        public string Name;

        /// <summary>
        /// The events which are classified under this category.</summary>
        public List<CalendarEvent> Events;

        /// <summary>
        /// The user-assigned symbol for this category.</summary>
        public Shape Symbol;

        /// <summary>
        /// The user-assigned colour for this category.</summary>
        public Color Colour;

        public CalendarCategory()
        {
            Events = new List<CalendarEvent>();
        }
    }

    public enum Shape
    {
        Star,
        Square,
        Circle,
        Triangle
    };
}
