using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
