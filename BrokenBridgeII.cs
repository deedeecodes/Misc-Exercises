using System;
using System.Collections.Generic;
using System.Linq;

namespace IttyBittyProblems
{
    public class BrokenBridgeII
    {
        public int BridgesII(string bridges)
        {
            int column = bridges.Substring(0, bridges.IndexOf('/') - 1).Length + 1;
            int line = 0;

            string[] bridgesSplit = bridges.Split('/');
            
            List<int> brokenLines = new List<int>();
            List<int> brokenColumns = new List<int>();

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
