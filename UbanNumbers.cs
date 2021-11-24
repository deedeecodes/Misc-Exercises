using System;

namespace IttyBittyProblems
{
    public class UbanNumbers
    {
        /*A number n is called uban if its name (in English) does not contain the letter "u". 
          In particular, it cannot contain the terms "four", "hundred", and "thousand", so the uban number following 99 is 1,000,000.
          Write a function to determine if the given integer is uban.
          From: https://edabit.com By: persolut*/

        public bool IsUban(int num)
        {
            if(num < 100 || num > 999999)
            {
                if (num % 10 != 4)
                    return true;
            }

            return false;
        }
    }
}
