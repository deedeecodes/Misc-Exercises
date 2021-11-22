using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class PerfectOrAmicable
    {
        public int DivisorSum(int num)
        {
            int sum = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    sum += i;
            }

            return sum;
        }

        public string NumType(int num)
        {
            int num2 = DivisorSum(num);

            if (num2 == num)
                return "Perfect";
            else if (DivisorSum(num2) == num)
                return "Amicable";

            return "Neither";
        }
    }
}
