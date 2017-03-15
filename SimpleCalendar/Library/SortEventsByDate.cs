using System;
using System.Collections.Generic;

namespace SimpleCalendar
{
    class SortEventsByDate : IComparer<CalendarEvent>
    {
        public int Compare(CalendarEvent x, CalendarEvent y)
        {
            if (x.StartingTime == y.StartingTime) {
                // the event which ends first comes first in sorted order
                return Convert.ToInt32(x.EndingTime.Subtract(y.EndingTime).TotalMilliseconds);
            } else {
                // the event which starts first comes first in sorted order
                return Convert.ToInt32(x.StartingTime.Subtract(y.StartingTime).TotalMilliseconds);
            }
        }
    }
}
