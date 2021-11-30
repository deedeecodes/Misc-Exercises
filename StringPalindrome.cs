using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace IttyBittyProblems
{
    public class StringPalindrome
    {

        public bool IsPalindrome(string str, string? chars)
        {
            str = str.ToLower();
            str = Regex.Replace(str, chars, "");

            string reversed = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            if (str.SequenceEqual(reversed))
                return true;

            return false;
        }

        public bool IsPalindrome(string str)
        {
            string reversed = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            if (str.SequenceEqual(reversed))
                return true;

            return false;
        }
    }
}
