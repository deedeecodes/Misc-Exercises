using System;

namespace IttyBittyProblems
{
    public class PerfectOrAmicable
    {
        /*Given a positive number x, if all the positive divisors of x (excluding x) add up to x, then x is said to be a perfect number.
          For example, the set of positive divisors of 6 excluding 6 itself is (1, 2, 3). The sum of this set is 6. Therefore, 6 is a perfect number.
          Given a positive number x, if all the positive divisors of x add up to a second number y, and all the positive divisors of y add up to x,
          then x and y are said to be a pair of amicable numbers.
          Create a function that takes a number and returns "Perfect" if the number is perfect, "Amicable" if the number is part of an amicable pair, or "Neither".
          From: https://edabit.com By: persolut*/

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
