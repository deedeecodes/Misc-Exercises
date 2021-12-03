using System;

namespace IttyBittyProblems
{
    public class NumberIsPalindrome
    {
        /*Create a function that returns true if a number is a palindrome.
          A palindrome is a number that remains the same when reversed.
          Bonus: Try solving this without turning the number into a string.
          From: https://edabit.com By: Pickle*/

        public  int Palindrome(int number)
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
        public  bool IsPalindrome(int number)
        {
            if (Palindrome(number) == number)
                return true;

            return false;
        }
    }
}
