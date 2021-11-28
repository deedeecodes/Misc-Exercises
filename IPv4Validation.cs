using System;
using System.Linq;

namespace IttyBittyProblems
{
    public class IPv4Validation
    {
        /*
         Create a function that takes a string (IPv4 address in standard dot-decimal format) and returns true if the IP is valid or false if it's not. For information on IPv4 formatting, please refer to the resources in the Resources tab.
         Examples

            IsValidIP("1.2.3.4") ➞ true
            IsValidIP("1.2.3") ➞ false
            IsValidIP("1.2.3.4.5") ➞ false
            IsValidIP("123.45.67.89") ➞ true
            IsValidIP("123.456.78.90") ➞ false
            IsValidIP("123.045.067.089") ➞ false

         IPv6 addresses are not valid.
         Leading zeros are not valid ("123.045.067.089" should return false).
         You can expect a single string for every test case.
         Numbers may only be between 1 and 255.
         The last digit may not be zero, but any other might.
         */

        public bool IsValid(string IP)
        {
            if (IP.Split('.').Length != 4)
                return false;

            int count = 0;

            foreach(string str in IP.Split('.'))
            {
                if(str.Any(x => char.IsLetter(x) || x == ' '))
                    return false;

                if (str.IndexOf('0') == str.Length - 1 && count == 3)
                    return false;

                if (str.Length > 1 && str[0] == '0')
                    return false;

                if (Int32.Parse(str) > 255 || Int32.Parse(str) < 0)
                    return false;

                count++;
            }

            return true;
        }
    }
}
