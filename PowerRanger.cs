using System;
using System.Linq;


namespace IttyBittyProblems
{
    public class PowerRanger
    {
        public int? PowerRange(int n, int a, int b)
        {
            if(a < b)
            {
                return Enumerable.Range(a, b - a + 1).Count(x => Math.Pow(x, 1 / (double) n) % 1 == 0);
            }

            return null;
        }
    }
}
