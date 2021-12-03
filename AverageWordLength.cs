using System;
using System.Text.RegularExpressions;


namespace IttyBittyProblems
{
    public class AverageWordLength
    {
        /*Create a function that takes in a sentence and returns the average length of each word in that sentence. Round your result to two decimal places.
          Ignore punctuation when counting the length of a word.
          From: https://edabit.com By: supafly*/

        public  double AverageLength(string str)
        {
            str = Regex.Replace(str, "[.?!,]", "");
            string[] words = str.Split(" ");
            double sum = 0;

            foreach(string word in words)
            {
                sum += word.Length;
            }

            return Math.Round(sum / words.Length, 2);
        }
    }
}
