using System;

namespace IttyBittyProblems
{
    public class FindTheBomb
    {
        /*Create a function that finds the word "bomb" in the given string (not case sensitive). If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".
          From: https://edabit.com By: Nomore*/

        public string Bomb(string message)
        {
            if (message.ToLower().Contains("bomb") == true)
            {
                return "Duck!";
            }
            else
            {
                return "There is no bomb, relax.";
            }
        }
    }
}
