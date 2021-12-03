using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class MilitaryTimeConverter
    {
        /* Create a function that converts 12-hour time to 24-hour time or vice versa. Return the output as a string.
           A 12-hour time input will be denoted with an am or pm suffix.
           A 24-hour input time contains no suffix.
           From: https://edabit.com By: supafly*/

        public  string ConvertTime(string time)
        {
            int posOfColumn = time.IndexOf(':');
            string minutes = time.Substring(posOfColumn, 3);
            int hour = Convert.ToInt32(time.Substring(0, posOfColumn));

            if (time.Contains("pm"))
            {
                return hour != 12 ? (hour + 12).ToString() + minutes : hour + minutes;
            }

            if (time.Contains("am"))
            {
                return hour == 12 ? "0" + minutes : hour + minutes;
            }

            if(hour == 0)
            {
                return "12" + minutes + " am";
            }

            return hour > 12 ? (hour - 12).ToString() + minutes + " pm" : time + " am";
        }
    }
}
