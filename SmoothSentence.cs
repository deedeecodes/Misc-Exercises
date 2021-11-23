using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class SmoothSentence
    {
        public bool IsSmooth(string sentence)
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
