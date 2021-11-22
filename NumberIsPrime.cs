using System;

namespace IttyBittyProblems
{
    public class NumberIsPrime
    {
        public bool IsPrime(int x)
        {
            int c = 0;

            if(x < 2)
                return false;

            for(int i = 2; i <= x / 2; i++)
            {
                if(x % i == 0)
                    c++;

                if(c > 0)
                    return false;
            }

            return true;
        }
    }
}
