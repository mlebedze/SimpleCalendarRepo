using System;
using System.Collections.Generic;

namespace SimpleCalendar
{
    /// <summary>
    /// Comparator to sort objects of type <c>CalendarEvent</c>.</summary>
    public class SortEventsByDate : IComparer<CalendarEvent>
    {
        /// <summary>
        /// Compares two <c>CalendarEvent</c>s and returns a value indicating whether one is less than, equal to, or greater than the other.</summary>
        /// <param name="x">The first <c>CalendarEvent</c> to compare.</param>
        /// <param name="y">The first <c>CalendarEvent</c> to compare.</param>
        /// <returns>A signed integer that indicates the relative values of <c>x</c> and <c>y</c>.</returns>
        public int Compare(CalendarEvent x, CalendarEvent y)
        {
            if (x.StartingTime == y.StartingTime) {
                // the event which ends first comes first in sorted order
                return Convert.ToInt32(x.EndingTime.Subtract(y.EndingTime).TotalMinutes);
            } else {
                // the event which starts first comes first in sorted order
                return Convert.ToInt32(x.StartingTime.Subtract(y.StartingTime).TotalMinutes);
            }
        }
    }
}
