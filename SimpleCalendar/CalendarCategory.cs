using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleCalendar
{
    public class CalendarCategory
    {
        public string name;
        public Shape symbol;
        public Color color;
    }

    public enum Shape
    {
        Star,
        Square,
        Circle,
        Triangle
    }
}
