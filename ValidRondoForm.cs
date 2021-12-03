using System;

namespace IttyBittyProblems
{
    public class ValidRondoForm
    {
        /*
         Rondo Form is a type of musical structure, in which there is a recurring theme/refrain, notated as A. Here are the rules for valid rondo forms:
         Rondo forms always start and end with an A section.
         In between the A sections, there should be contrasting sections notated as B, then C, then D, etc... No letter should be skipped.
         There shouldn't be any repeats in the sequence (such as ABBACCA).
         Create a function which validates whether a given string is a valid Rondo Form.
         Inputs will be given as all uppercase.
         For the purposes of this challenge, accept ABA as valid Rondo forms.
         From: https://edabit.com By: persolut
         */

        public  bool ValidRondo(string s)
        {
            char currentContrast = 'B';

            if (s.Length <= 1 || s[s.Length - 1] != 'A')
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0 && s[i] != 'A')
                    return false;

                if (i % 2 == 1 && s[i] != currentContrast)
                {
                    return false;
                }
                else if(i % 2 == 1)
                {
                    currentContrast = (char) (currentContrast + 1);
                }
            }

            return true;
        }
    }
}
