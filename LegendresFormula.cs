using System;

namespace IttyBittyProblems
{
    public class LegendresFormula
    {
        /*
           Legendre's formula finds the exponent of the largest power of some prime p that divides (is a factor of) the factorial of some number n.
           The formula returns the sum of many fractions (rounded down) with n as the numerator and a steadily increasing power of p as the denominator,
           stopping when it exceeds the numerator.
           Example:
                p = 2
                n = 128
                int(128/2) + int(128/4) + int(128/8) + ... + int(128/128)

           p and n will be positive integers.
           When p exceeds n, the result should be 0.
           From: https://edabit.com By: persolut
         */

        public int Legendre(int p, int n)
        {
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                if(Math.Pow(p, i) > n)
                {
                    break;
                }

                sum += n / (int) Math.Pow(p, i);
            }

            return sum;
        }
    }
}
