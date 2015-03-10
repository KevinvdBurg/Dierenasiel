using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dierenasiel
{
    public class SimpleDate
    {
        private DateTime date;

        public int Day { get; private set; }

        public int Month { get; private set; }
            
        public int Year { get; private set; }

        public SimpleDate(int day, int month, int year)
        {
            date = new DateTime(year, month, day);
        }

        public int DaysDifference(SimpleDate date)
        {
            TimeSpan timespan = date.date.Subtract(this.date);
            return timespan.Days;
        }

        public string ToString()
        {
            return date.ToString("dd-MM-yyyy");
        }
    }
}
