using System;
using System.Collections.Generic;
using System.Linq;

namespace IttyBittyProblems
{
    public class LongestAbecedarianWord
    {
        /*
          An abecedarian word is a word where all of its letters are arranged in alphabetical order. Examples of these words include:
             Empty
             Forty
             Almost
          Given an array of words, create a function which returns the longest abecedarian word. If no word in an array matches the criterea, return an empty string.
          All words will be given in lowercase.
          If two abecedarian words have the same length, return the word which appeared first in the array.
          From: https://edabit.com By: persolut
         */

        public  bool IsABC(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] > word[i + 1])
                    return false;
            }

            return true;
        }

        public  string LongestABC(string[] arr)
        {
            List<string> abcWords = new List<string>();

            foreach(string word in arr)
            {
                if(IsABC(word))
                {
                    abcWords.Add(word);
                }
            }

            abcWords = abcWords.OrderByDescending(x => x.Length).ToList();

            return abcWords.Count == 0 ? "" : abcWords[0];
        }
    }
}
