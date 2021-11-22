using System;

namespace IttyBittyProblems
{
    public class FindTheBomb
    {
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
