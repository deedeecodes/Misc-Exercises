using System;
using System.Linq;

namespace IttyBittyProblems
{
    public class KeepingCount
    {
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
