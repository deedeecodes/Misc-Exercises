using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class CollatzConjecture
    {
        public int DoCollatz(long a)
        {
            int steps = 0;

            while(a != 1)
            {
                if (a % 2 == 0)
                {
                    a /= 2;
                }
                else
                {
                    a = a * 3 + 1;
                }

                steps++;
            }

            return steps;
        }

        public string Collatz(long a, long b)
        {
            int stepsA = DoCollatz(a);
            int stepsB = DoCollatz(b);

            return Math.Min(stepsA, stepsB) == stepsA ? "a" : "b"; 
        }
    }
}
