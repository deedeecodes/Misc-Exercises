using System;

namespace IttyBittyProblems
{
    public class SnailCrawl
    {
        /*
           A snail fell into a bucket and wanted to crawl out. Assuming we already know the snail can climb 5cm per minute, the snail can crawl for 30 minutes continuously and then needs to rest for 10 minutes. 
           When it is resting it will slide down 30cm.
           How many minutes will it take for the snail to crawl out from different depths? 
           Create a function that takes the bucket depth (the unit is cm) as an argument and returns the time in minutes.
           The depth is a positive integer.
           If the time is less than one minute it still counts as one minute.
           From: https://edabit.com By: persolut
         */

        public int Crawl(int depth)
        {
            int minutes = 0;

            while (depth > 150)
            {
                depth -= 120;
                minutes += 40;
            }

            return (int) Math.Ceiling((double)depth / 5) + minutes;
        }
    }
}
