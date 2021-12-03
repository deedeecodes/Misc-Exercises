using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class SplitStringIntoN
    {
        /* Create a function that accepts string input and int cases as parameters where the string is split into N distinct cases of equal length as shown:

                SplitNCases("Strengthened", 6) ➞ { "St", "re", "ng", "th", "en", "ed" }
                SplitNCases("Unscrupulous", 2) ➞ { "Unscru", "pulous" }
                SplitNCases("Flavorless", 1) ➞ { "Flavorless" }

           If it's not possible to split the string as described, return { "Error" }.
           From: https://edabit.com By: Sinomede*/

        public  string[] SplitNCases(string str, int n)
        {
            if (str.Length % n != 0)
                return new string[] { "Error" };

            int step = str.Length / n;
            string[] splitStr = new string[n];
            int count = 0;

            for (int i = 0; i < str.Length; i += step)
            {
                splitStr[count] = str.Substring(i, step);
                count++;
            }

            return splitStr;
        }
    }
}
