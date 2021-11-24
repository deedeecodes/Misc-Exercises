using System;

namespace IttyBittyProblems
{
    public class NumberIsPrime
    {
        /*Create a function that returns true if a number is prime, and false otherwise. 
          A prime number is any positive integer that is evenly divisible by only two divisors: 1 and itself.
          From: https://edabit.com By: Helen Yu*/
        public bool IsPrime(int x)
        {
            if(x < 2)
                return false;

            for(int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                    return false;
            }

            return true;
        }
    }
}
