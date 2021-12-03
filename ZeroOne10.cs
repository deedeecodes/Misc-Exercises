using System;
using System.Collections.Generic;

namespace IttyBittyProblems
{
    public class ZeroOne10
    {
        /*
           Create a function that takes a string as an argument. 
           The function must return a string containing 1s and 0s based on the string argument's words. 
           If any word in the argument is not equal to "zero" or "one" (case insensitive), you should ignore it. 
           The returned string's length should be a multiple of 8, if the string is not a multiple of 8 you should remove the numbers in excess.
           From: https://edabit.com By: supafly
         */

        public  string TextToNumbers(string str)
        {
            Dictionary<string, string> converter = new Dictionary<string, string>() 
            {
                {"zero", "0"},
                {"one", "1"}
            };

            string converted = "";

            str = str.ToLower();
            int multiple = 0;

            foreach (string word in str.Split(" "))
            {
                if (converter.ContainsKey(word))
                {
                    converted += converter[word];
                    multiple++;
                }
            }
            
            if (multiple < 8)
            {
                return "";
            }
            else if(multiple % 8 != 0)
            {
                multiple = 8 * (multiple / 8);
            }

            return converted.Substring(0, multiple);
        }
    }
}
