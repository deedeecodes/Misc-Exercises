using System;

namespace IttyBittyProblems
{
    public class UbanNumbers
    {
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
