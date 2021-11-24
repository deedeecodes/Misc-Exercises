using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class CreatingAPictureFrame
    {
        /* Create a function that takes the width, height and character and returns a picture frame as an array of strings (string[]).
           Remember the gap.
           Return ["invalid"] if width or height is less than 3 (can't put anything inside).
           From: https://edabit.com By: persolut*/

        public string[] GetFrame(int width, int height, char frameType)
        {
            string[] frame = new string[height];
            if (width < 3 || height < 3)
                return new string[] { "invalid" };

            frame[0] = new string(frameType, width);
            frame[height - 1] = new string(frameType, width);

            for(int i = 1; i < height - 1; i++)
            {
                frame[i] = frameType + new string(' ', width - 2) + frameType;
            }

            return frame;
        }
    }
}
