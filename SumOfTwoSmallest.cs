using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
