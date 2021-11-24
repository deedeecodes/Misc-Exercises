using System;

namespace IttyBittyProblems
{
    public class ReverseAndNotInt
    {
        /*Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
          To illustrate:
          We reverse "123" to get "321" and then add "123" to the end, resulting in "321123".
          From: https://edabit.com By: rob313663*/

        public string? ReverseAndNot(int i)
        {
            NumberIsPalindrome utility = new NumberIsPalindrome();

            if (i < 0)
                return null;

            return utility.Palindrome(i) + i.ToString();
        }
    }
}
