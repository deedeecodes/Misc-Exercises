using System;

namespace IttyBittyProblems
{
    public class ImaginaryInterview
    {
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
