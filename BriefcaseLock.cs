using System;

namespace IttyBittyProblems
{
    public class BriefcaseLock
    {
        /*A briefcase has a 4-digit rolling-lock. Each digit is a number from 0-9 that can be rolled either forwards or backwards.
          Create a function that returns the smallest number of turns it takes to transform the lock from the current combination to the target combination. 
          One turn is equivalent to rolling a number forwards or backwards by one.
          To illustrate:
            current-lock: 4089
            target-lock: 5672
          It takes 1 + 4 + 1 + 3 = 9 minimum turns to change the lock from 4089 to 5672.
          From: https://edabit.com By: supafly*/

        public int Roll(char current, char target, string direction)
        {
            int curr = Convert.ToInt32(current);
            int tar = Convert.ToInt32(target);

            if (curr == tar)
            {
                return 0;
            }

            if(direction == "backward")
            {
                return tar > curr ? curr + 10 - tar : curr - tar;
            }
            else if(direction == "forward")
            {
                return tar > curr ? tar - curr : 9 - curr + tar + 1;
            }
            else
            {
                return -1;
            }
        }

        public int MinTurns(string current, string target)
        {
            int sum = 0;
            for(int i = 0; i < current.Length; i++)
            {
                int forward = Roll(current[i], target[i], "forward");
                int backward = Roll(current[i], target[i], "backward");
                sum += Math.Min(forward, backward);
            }

            return sum;
        }

    }
}
