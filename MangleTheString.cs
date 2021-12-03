using System;
using System.Linq;

namespace IttyBittyProblems
{
    public class MangleTheString
    {
        /*
            Create a function that takes a string and replaces every letter with the letter following it in the alphabet ("c" becomes "d", "z" becomes "a", "b" becomes "c", etc).
            Then capitalize every vowel (a, e, i, o, u) and return the new modified string.
            If a letter is already uppercase, return it as uppercase (regardless of being a vowel).
            "y" is not considered a vowel.
            From: https://edabit.com By: Pickle
         */

        public  string Mangle(string str)
        {
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    if (str[i] == 'Z' || str[i] == 'z')
                    {
                        result += 'A';
                    }
                    else if (vowels.Contains((char)(str[i] + 1)))
                    {
                        result += char.ToUpper((char)(str[i] + 1));
                    }
                    else
                    {
                        result += (char)(str[i] + 1);
                    }
                }
                else
                {
                    result += str[i];
                }
            }

            return result;
        }
    }
}
