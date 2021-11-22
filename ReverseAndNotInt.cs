using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
