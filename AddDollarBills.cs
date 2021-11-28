using System;
using System.Linq;

namespace IttyBittyProblems
{
    public class AddDollarBills
    {
        /*
          Create a function that takes a string containing money in dollars and pounds sterling (seperated by comma+space)
          and returns the sum of dollar bills only, as an integer.
          For the input string:
          Each amount is prefixed by the currency symbol: $ for dollars and £ for pounds.
          Thousands are represented by the suffix k.
          There is at least one dollar bill in string.
          From: https://edabit.com By: persolut
         */

        public int AddBills(string money)
        {
            string[] bills = money.Replace(" ", "").Split(',');
            bills = bills.Where(x => x.Contains('$')).ToArray();
            int sum = 0;

            foreach(string bill in bills)
            {

                if(bill.Contains('k'))
                {
                    sum += Int32.Parse(bill.Replace("$", "").Replace("k", "")) * 1000;
                }
                else
                {
                    sum += Int32.Parse(bill.Replace("$", ""));
                }
            }

            return sum;
        }
    }
}
