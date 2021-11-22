using System;
using System.Linq;

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
