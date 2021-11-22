using System;
using System.Linq;

namespace IttyBittyProblems
{
    public class CensoredStrings
    {
        public string Uncensor(string txt, string vowels)
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
