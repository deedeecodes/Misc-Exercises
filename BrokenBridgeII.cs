using System;
using System.Collections.Generic;
using System.Linq;

namespace IttyBittyProblems
{
    public class BrokenBridgeII
    {
        /*Create a function to return the count of all bridges in a two-dimensional grid.
          Bridge B should be counted if:
          It connects from one end of the grid to the one opposite to it.
          It is unobstructed.
          Vertical bridges count.
          From: https://edabit.com By: Sinomede*/

        public int BridgesII(string bridges)
        {
            string[] bridgesSplit = bridges.Split('/');
            
            List<int> brokenLines = new List<int>();
            List<int> brokenColumns = new List<int>();

            int column = bridgesSplit[0].Length;
            int line = 0;

            foreach (string bridge in bridgesSplit)
            {
                for (int j = 0; j < column; j++)
                {
                    if(bridge[j] == ' ')
                    {
                        if (!brokenLines.Contains(line))
                            brokenLines.Add(line);

                        if (!brokenColumns.Contains(j))
                            brokenColumns.Add(j);
                    }
                }

                line++;
            }

            int brokenBridges = brokenLines.Count + brokenColumns.Count;
            int totalBridges = column + line;

            return totalBridges - brokenBridges;
        }
    }
}
