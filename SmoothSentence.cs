using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class SmoothSentence
    {
        /*Carlos is a huge fan of something he calls smooth sentences.
          A smooth sentence is one where the last letter of each word is identical to the first letter the following word (and not case sensitive, so "A" would be the same as "a").
          The following would be a smooth sentence "Carlos swam masterfully" because "Carlos" ends with an "s" 
          and swam begins with an "s" and swam ends with an "m" and masterfully begins with an "m".
          Create a function that determines whether the input sentence is a smooth sentence, returning a boolean value true if it is, false if it is not.
          From: https://edabit.com By: supafly*/

        public  bool IsSmooth(string sentence)
        {
            string[] words = sentence.Split(' ');

            for(int i = 0; i < words.Length - 1; i++)
            {
                int lastPos = words[i].Length - 1;
                char ending = char.ToLower(words[i][lastPos]);
                char nextStart = char.ToLower(words[i + 1][0]);

                if(ending != nextStart)
                {
                    return false;
                }

            }

            return true;
        }
    }
}
