using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class RollingCipher
    {
        /* Write a function that accepts a string and an n and returns a cipher by rolling each character forward (n > 0) or backward (n < 0) n times.
           Note: Think of the letters as a connected loop, so rolling a backwards once will yield z, and rolling z forward once will yield a. 
           If you roll 26 times in either direction, you should end up back where you started.
           All letters are lower cased.
           No spacing.
           Each character is rotated the same number of times.
           From: https://edabit.com By: supafly*/

        public  string Cipher(string str, int n)
        {
            char[] strChars = str.ToCharArray();

            for (int i = 0; i < strChars.Length; i++)
            {
                if (strChars[i] + n > 122)
                {
                    strChars[i] = (char)(strChars[i] - 26);
                }

                if (strChars[i] + n < 97)
                {
                    strChars[i] = (char)(strChars[i] + 26);
                }

                strChars[i] = (char)(strChars[i] + n); 
            }

            return new string(strChars);
        }
    }
}
