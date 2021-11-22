using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class PositiveCountNegativeSum
    {
        public double[] CountPosSumNeg(double[] arr)
        {
            if (arr == null || arr.Length == 0)
                return new double[] { };

            var countPositive = arr.Count(x => x > 0);
            var sumNegative = arr.Where(x => x < 0).Sum();

            return new double[] { countPositive, sumNegative };
        }
    }
}
