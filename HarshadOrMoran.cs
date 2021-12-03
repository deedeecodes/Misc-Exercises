using System;
using System.Linq;


namespace IttyBittyProblems
{
    public class HarshadOrMoran
    {
        /*
          A Harshad number is a number which is divisible by the sum of its digits. For example, 132 is divisible by 6 (1+3+2).
          A subset of the Harshad numbers are the Moran numbers. 
          Moran numbers yield a prime when divided by the sum of their digits. For example, 133 divided by 7 (1+3+3) yields 19, a prime.  
          Create a function that takes a number and returns "M" if the number is a Moran number, "H" if it is a (non-Moran) Harshad number, or "Neither".
          From: https://edabit.com By: persolut
         */

        public  int DigitSum(int num)
        {
            return num.ToString().Sum(x => Convert.ToInt32(x) - 48);
        }

        public  string HOrM(int num)
        {
            NumberIsPrime check = new NumberIsPrime();

            if(num % DigitSum(num) == 0)
            {
                if (check.IsPrime(num / DigitSum(num)))
                {
                    return "M";
                }

                return "H";
            }

            return "Neither";
        }
    }
}
