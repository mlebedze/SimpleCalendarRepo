using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalendar
{
    public class CalendarEvent
    {
        public DateTime start;
        public DateTime end;
        public string title;
        public string location;
        public string description;
        public RecurringType recurring;
    }

    public enum RecurringType
    {
        Daily,
        Weekly,
        Monthly,
        Yearly,
        None
    }
}
