using System;
using System.Linq;

namespace IttyBittyProblems
{
    public class KeepingCount
    {
        /*Given a number, create a function which returns a new number based on the following rules:
          For each digit, replace it by the number of times it appears in the number.
          The final instance of the number will be an integer, not a string.
          From: https://edabit.com By: persolut*/

        public long DigitCount(long num)
        {
            int[] digits = num.ToString().ToCharArray().Select(x => Convert.ToInt32(x) - 48).ToArray();
            long newNum = 0;

            for(int i = 0; i < digits.Length; i++)
            {
                newNum += digits.Count(x => x == digits[i]) * (long)Math.Pow(10, digits.Length - 1 - i);
            }

            return newNum;
        }
    }
}
