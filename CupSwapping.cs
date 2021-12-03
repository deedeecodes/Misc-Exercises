using System;

namespace IttyBittyProblems
{
    public class CupSwapping
    {
        /*
           There are three cups on a table, at positions A, B, and C. At the start, there is a ball hidden under the cup at position B.
           However, I perform several swaps on the cups, which is notated as two letters. 
           For example, if I swap the cups at positions A and B, I could notate this as AB or BA.
           Create a function that returns the letter position that the ball is at, once I finish swapping the cups. The swaps will be given to you as an array.
           A swap could be notated in two different ways, since both ways end up with the same outcome.
           All swaps will be notated as capital letters and will be valid.
           You cannot swap a cup with itself.
           From: https://edabit.com By: persolut
         */

        public  string CupSwaps(string[] swaps)
        {
            string currentPos = "B";

            foreach(string swap in swaps)
            {
                if(swap.Contains(currentPos))
                {
                    currentPos = swap.Replace(currentPos, "");
                }
            }

            return currentPos;
        }
    }
}