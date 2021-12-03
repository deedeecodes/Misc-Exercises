using System;

namespace IttyBittyProblems
{
    public class OneStringInOther
    {
        /*
          Create a function that takes two strings and returns true if either of the strings appears at the very end of the other string. 
          Return false otherwise. 
          The character * is a wildcard, so it can take the place of any character.
          From: https://edabit.com By: supafly
         */


        public  string ReturnSubstring(string str1, string str2)
        {
            return str1.Substring(str1.Length - str2.Length, str2.Length);
        }

        public  bool Overlap(string str1, string str2)
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            string toCompare = "";
            string ending = "";

            if(str1.Length >= str2.Length)
            {
                toCompare = ReturnSubstring(str1, str2); 
                ending = str2;
            }
            else
            {
                toCompare = ReturnSubstring(str2, str1);
                ending = str1;
            }

            for (int i = 0; i < toCompare.Length; i++)
            {
                if(toCompare[i] == '*' || ending[i] == '*')
                {
                    continue;
                }
                    
                if(toCompare[i] != ending[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
