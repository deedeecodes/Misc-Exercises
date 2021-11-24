using System;
using System.Globalization;

namespace IttyBittyProblems
{
    public class DayRobWasBorn
    {
        /*I was born on the 21st of September in the year of 1970. That was a Monday.Where I was born that weekday is called måndag.
          Write a method that when passed a date as year/month/ day and returns the date's weekday name in the Dutch culture. The culture identifier to use is "nl-NL". Not "nl-BE".
          You can assume the specified date is valid.
          Looking at the tests and doing a switch statement or similar is considered cheating.
          System.Globalization.CultureInfo should be used.
          From: https://edabit.com By: rob313663*/

        public string WeekdayRobWasBornInDutch(int year, int month, int day)
        {
            CultureInfo culture = new CultureInfo("nl-NL");
            DateTime birthday = new DateTime(year, month, day);

            return culture.DateTimeFormat.GetDayName(birthday.DayOfWeek);
        }
    }
}
