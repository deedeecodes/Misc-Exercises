using System;
using System.Linq;

namespace IttyBittyProblems
{
    public class ATMPinValidation
    {
        /*ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits. 
          Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.
          From: https://edabit.com By: Николай*/
        public  bool ValidatePIN(string pin)
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
