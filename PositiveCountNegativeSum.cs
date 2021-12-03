using System;
using System.Linq;

namespace IttyBittyProblems
{
    public class PositiveCountNegativeSum
    {
        /*Create a function that takes an array of positive and negative numbers. 
          Return an array where the first element is the count of positive numbers and the second element is the sum of negative numbers.
          If given an empty array, return an empty array: []
          Cast sum to int, don't mind the remaining decimal places.
          0 is not positive.
          From: https://edabit.com By: Николай*/

        public  double[] CountPosSumNeg(double[] arr)
        {
            if (arr == null || arr.Length == 0)
                return new double[] { };

            var countPositive = arr.Count(x => x > 0);
            var sumNegative = arr.Where(x => x < 0).Sum();

            return new double[] { countPositive, sumNegative };
        }
    }
}
