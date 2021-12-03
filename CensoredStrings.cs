using System;
using System.Linq;

namespace IttyBittyProblems
{
    public class CensoredStrings
    {
        /*Someone has attempted to censor my strings by replacing every vowel with a *, l*k* th*s. 
          Luckily, I've been able to find the vowels that were removed.
          Given a censored string and a string of the censored vowels, return the original uncensored string. 
          From: https://edabit.com By: persolut*/

        public  string Uncensor(string txt, string vowels)
        {
            char[] txtChar = txt.ToCharArray();
            int count = 0;

            while(txtChar.Contains('*'))
            {
                txtChar[Array.IndexOf(txtChar, '*')] = vowels[count];
                count++;
            }

            return String.Join("", txtChar);
        }
    }
}
