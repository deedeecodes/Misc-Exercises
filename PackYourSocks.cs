using System;
using System.Collections.Generic;

namespace IttyBittyProblems
{
    public class PackYourSocks
    {
        public int? SockPairs(string socks)
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
