using System;
using System.Linq;

namespace IttyBittyProblems
{
    public class SumOfTwoSmallest
    {
        public int SumOfSmallest(int[] arr)
        {
            var sum = arr.Where(x => x > -1)
                         .OrderBy(x => x).Take(2).Sum();

            return sum;
        }
    }
}
