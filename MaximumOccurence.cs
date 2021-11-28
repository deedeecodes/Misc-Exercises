using System;
using System.Collections.Generic;
using System.Linq;

namespace IttyBittyProblems
{
    public class MaximumOccurence
    {
        /*
          Given a string text. 
          Write a function that returns the character with the highest frequency. If more than 1 character has the same highest frequency, return all those characters as a comma separated string. 
          If there is no repetition in characters, return "No Repetition".
          Characters are case sensitive, so, for example, "C" and "c" are counted separately
          From: https://edabit.com By: persolut
         */

        public string MaxOccurence(string str)
        {
            Dictionary<char, int> occurences = new Dictionary<char, int>();

            foreach(char character in str)
            {
                if(!occurences.ContainsKey(character))
                {
                    occurences.Add(character, 1);
                }
                else
                {
                    occurences[character]++;
                }
            }

            int max = occurences.Max(x => x.Value);
            var sortedOccurences = occurences.OrderBy(x => x.Key);
            string result = "";

            if(max == 1)
            {
                return "No Repetition";
            }

            foreach(var occurence in sortedOccurences)
            {
                if(occurence.Value == max)
                {
                    result += occurence.Key + ", ";
                }
            }

            return result.Remove(result.Length - 2);
        }
    }
}
