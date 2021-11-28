using System;
using System.Linq;

namespace IttyBittyProblems
{
    public class SmallestMissingPosInt
    {
        /*
          Given an array of integers, return the smallest positive integer not present in the array.
          Here is a representative example. Consider the array:
            
            { -2, 6, 4, 5, 7, -1, 7, 1, 3, 6, 6, -2, 9, 10, 2, 2 }

          After reordering, the array becomes:

          { -2, -2, -1, 1, 2, 2, 3, 4, 5, 6, 6, 6, 7, 7, 9, 10 }

          ... from which we see that the smallest missing positive integer is 8.
          From: https://edabit.com/ By: persolut
         */

        public int SmallestMissing(int[] arr)
        {
            int[] sorted = arr.OrderBy(x => x).ToArray();
            int minPos = sorted[sorted.Length - 1] + 1;

            for (int i = 0; i < sorted.Length - 1; i++)
            {
                if(sorted[i] >= 0 && sorted[i + 1] > sorted[i] + 1)
                {
                    minPos = minPos < sorted[i] + 1 ? minPos : sorted[i] + 1;
                }
            }

            return minPos;
        }

    }
}
