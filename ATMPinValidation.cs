using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IttyBittyProblems
{
    public class ATMPinValidation
    {
        public bool ValidatePIN(string pin)
        {
            if (String.IsNullOrEmpty(pin))
                return false;

            if (pin.Length != 4 && pin.Length != 6)
                return false;

            if (!pin.All(char.IsDigit))
                return false;

            return true;
        }
    }
}
