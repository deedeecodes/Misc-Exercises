using System;
using System.Linq;

namespace IttyBittyProblems
{
    public class SumOfTwoSmallest
    {
        /*Create a function that takes an array of numbers and returns the sum of the two lowest positive numbers.
          Don't count negative numbers.
          Floats and empty arrays will not be used in any of the test cases.
          From: https://edabit.com By: Andrew Rosenwinkel*/

        public int SumOfSmallest(int[] arr)
        {
            var sum = arr.Where(x => x > -1)
                         .OrderBy(x => x).Take(2).Sum();

            return sum;
        }
    }
}
