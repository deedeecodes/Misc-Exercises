using System;

namespace IttyBittyProblems
{
    public class ImaginaryInterview
    {
        /*Create a function to check if a candidate is qualified in an imaginary coding interview of an imaginary tech startup.
          The criteria for a candidate to be qualified in the coding interview is:
          The candidate should have complete all the questions.
          The maximum time given to complete the interview is 120 minutes.
          The maximum time given for very easy questions is 5 minutes each.
          The maximum time given for easy questions is 10 minutes each.
          The maximum time given for medium questions is 15 minutes each.
          The maximum time given for hard questions is 20 minutes each.
          If all the above conditions are satisfied, return "qualified", else return "disqualified".
          You will be given an array of time taken by a candidate to solve a particular question and the total time taken by the candidate to complete the interview.
          Given an array, in a true condition will always be in the format [very easy, very easy, easy, easy, medium, medium, hard, hard].
          The maximum time to complete the interview includes a buffer time of 20 minutes. 
          From: https://edabit.com By: persolut*/

        public string Interview(int[] questionTime, int completionTime)
        {
            if (completionTime > 120)
                return "disqualified";

            if (questionTime.Length < 8)
                return "disqualified";

            int[] expectedTime = new int[] { 5, 5, 10, 10, 15, 15, 20, 20};
            for(int i = 0; i < questionTime.Length; i++)
            {
                if (questionTime[i] > expectedTime[i])
                    return "disqualified";
            }

            return "qualified";
        }

    }
}
