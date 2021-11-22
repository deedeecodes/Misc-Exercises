using System;

namespace IttyBittyProblems
{
    public class ReverseAndNotInt
    {
        public string? ReverseAndNot(int i)
        {
            NumberIsPalindrome utility = new NumberIsPalindrome();

            if (i < 0)
                return null;

            return utility.Palindrome(i) + i.ToString();
        }
    }
}
