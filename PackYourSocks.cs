using System;
using System.Collections.Generic;

namespace IttyBittyProblems
{
    public class PackYourSocks
    {
        /*Joseph is in the middle of packing for a vacation. He's having a bit of trouble finding all of his socks, though.
          Write a function that returns the number of sock pairs he has. A sock pair consists of two of the same letter, such as "AA". 
          The socks are represented as an unordered sequence.
          From: https://edabit.com By: supafly*/

        public  int? SockPairs(string socks)
        {
            Dictionary<char, int> sockTypes = new Dictionary<char, int>();
            int pairs = 0;

            foreach(char sock in socks)
            {
                if(sockTypes.ContainsKey(sock))
                {
                    sockTypes[sock]++;
                }
                else
                {
                    sockTypes.Add(sock, 1);
                }
            }

            foreach(KeyValuePair<char, int> kvp in sockTypes)
            {
                pairs += kvp.Value / 2;
            }

            return pairs;
        }
    }
}
