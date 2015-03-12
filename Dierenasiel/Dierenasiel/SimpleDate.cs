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

        /// <summary>
        /// Creates a SimpleDate object whicht stores the given date.
        /// </summary>
        /// <param name="day">The day of the month</param>
        /// <param name="month">The month of the year</param>
        /// <param name="year">The year</param>
        public SimpleDate(int day, int month, int year)
        {
            date = new DateTime(year, month, day);
        }

        /// <summary>
        /// Get the number of days between this object's date and the given date.
        /// </summary>
        /// <param name="date">The end date.</param>
        /// <returns>The number of days between this date and endDate.</returns>
        public int DaysDifference(SimpleDate date)
        {
            TimeSpan timespan = date.date.Subtract(this.date);
            return timespan.Days;
        }

        /// <summary>
        /// Returns the date info in the form DD-MM-YYYY (e.g. "04-11-2013").
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString method which you can override for your own good.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return date.ToString("dd-MM-yyyy");
        }
    }
}
