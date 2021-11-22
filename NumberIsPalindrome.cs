using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class NumberIsPalindrome
    {
        public int Palindrome(int number)
        {
            int copy = number;
            int palindrome = 0;

            while (copy > 0)
            {
                palindrome = palindrome * 10 + copy % 10;
                copy /= 10;
            }

            return palindrome;
        }
        public bool IsPalindrome(int number)
        {
            if (Palindrome(number) == number)
                return true;

            return false;
        }
    }
}
