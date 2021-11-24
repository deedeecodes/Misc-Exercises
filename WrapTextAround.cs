using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class WrapTextAround
    {
        /* Create a function to reproduce the wrap around effect shown:
         
                WrapAround("Hello, World!", 2) ➞ "llo, World!He"
                WrapAround("From what I gathered", -4) ➞ "eredFrom what I gath"
                WrapAround("Excelsior", 30) ➞ "elsiorExc"
                WrapAround("Nonscience", -116) ➞ "cienceNons"

           The offset can be negative.
           The offset can be greater than the input string's length.
           From: https://edabit.com By: Sinomede*/

        public string WrapAround(string str, int n)
        {
            int offset = n % str.Length;

            if(offset < 0)
            {
                offset += str.Length;
            }

            return str.Remove(0, offset) + str.Substring(0, offset);
        }
    }
}
