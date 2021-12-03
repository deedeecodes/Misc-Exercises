using System;
using System.Linq;


namespace IttyBittyProblems
{
    public class PowerRanger
    {
        /*Create a function that takes in n, a, b and returns the number of positive values raised to the nth power that lie in the range [a, b], inclusive.
          From: https://edabit.com By: supafly*/

        public  int? PowerRange(int n, int a, int b)
        {
            if(a < b)
            {
                return Enumerable.Range(a, b - a + 1).Count(x => Math.Pow(x, 1 / (double) n) % 1 == 0);
            }

            return null;
        }
    }
}
