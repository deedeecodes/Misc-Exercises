using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class SumOfFactorsOfFactors
    {
        /* Create a function that takes a number and returns the sum of factors of factors of the given number.
           The number will always be greater than 0.
           Factors that are equal to the number or 1 don't count.
           From: https://edabit.com By: persolut*/

        public  List<int> Divisors(int a)
        {
            List<int> divisors = new List<int>();

            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }
        public  int SumOfFF(int a)
        {
            NumberIsPrime number = new NumberIsPrime();
            int sum = 0;

            foreach(int divisor in Divisors(a))
            {
                if (number.IsPrime(divisor) == false)
                {
                    foreach (int divisorOfDivisor in Divisors(divisor))
                    {
                        sum += divisorOfDivisor;
                    }
                }
            }

            return sum;
        }
    }
}
