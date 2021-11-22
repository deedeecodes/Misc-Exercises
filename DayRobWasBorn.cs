using System;
using System.Globalization;

namespace IttyBittyProblems
{
    public class DayRobWasBorn
    {
        public string WeekdayRobWasBornInDutch(int year, int month, int day)
        {
            CultureInfo culture = new CultureInfo("nl-NL");
            DateTime birthday = new DateTime(year, month, day);

            return culture.DateTimeFormat.GetDayName(birthday.DayOfWeek);
        }
    }
}
