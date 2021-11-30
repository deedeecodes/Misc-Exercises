using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace IttyBittyProblems
{
    public class StringPalindrome
    {

        public bool IsPalindrome(string str)
        {
            str = str.ToLower();
            str = Regex.Replace(str, "[?!:;., \n\t]", "");

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
