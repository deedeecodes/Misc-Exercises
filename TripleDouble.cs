using System;
using System.Text.RegularExpressions;

namespace IttyBittyProblems
{
    public class TripleDouble
    {
        /*Create a function that takes two integers and returns true if a digit repeats 
          three times in a row at any place in num1 AND that same digit repeats two times in a row in num2.
          From: https://edabit.com By: Pickle*/

        public  bool Trouble(long num1, long num2)
        {
            string a = num1.ToString();
            string b = num2.ToString();

            for(int i = 0; i < 10; i++)
            {
                if (Regex.Match(a, i + @"{3,}").Success && Regex.Match(b, i + @"{2,}").Success)
                {
                    return true;
                }          
            }

            return false;
        }
    }
}
