using System;

namespace IttyBittyProblems
{
    public class DifferenceCipher
    {
        /*
          It's time to send and receive secret messages.
          Create two functions that take a string and an array and returns a coded or decoded message.
          The first letter of the string, or the first element of the array represents the Character Code of that letter. 
          The next elements are the differences between the characters: e.g. A +3 --> C or z -1 --> y.
          The input of the encrypt function will always be a string.
          The input of the decrypt function will always be an array with numbers.  
          From: https://edabit.com By: mqqqqqx
         */

        public int[] Encrypt(string str)
        {
            int[] arr = new int[str.Length];
            arr[0] = str[0];

            for (int i = 0; i < str.Length - 1; i++)
            {
                arr[i + 1] = str[i + 1] - str[i];
            }

            return arr;
        }

        public string Decrypt(int[] arr)
        {
            string str = "";
            str += (char)arr[0];

            str += (char)(arr[0] + arr[1]);
            char key = (char)(arr[0] + arr[1]);
            for (int i = 2; i < arr.Length; i++)
            {
                str += (char)(key + arr[i]);
                key = str[i];
            }

            return str;
        }
    }
}
