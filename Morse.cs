using System;
using System.Collections.Generic;
using System.Linq;

namespace IttyBittyProblems
{
    public class Morse
    {
        /* 
           Encode and Decode International Morse Code
           For dictionary info I used: https://morsecode.world/international/translator.html
         */
        private static Dictionary<char, string> morse = new Dictionary<char, string>()
        {
            { 'a', ".-"},
            { 'b', "-..." },
            { 'c', "-.-."},
            { 'd', "-.."},
            { 'e', "."},
            { 'f', "..-."},
            { 'g', "--." },
            { 'h', "...."},
            { 'i', ".."},
            { 'j', ".---"},
            { 'k', "-.-"},
            { 'l', ".-.."},
            { 'm', "--"},
            { 'n', "-."},
            { 'o', "---"},
            { 'p', ".--."},
            { 'q', "--.-"},
            { 'r', ".-."},
            { 's', "..."},
            { 't', "-"},
            { 'u', "..-"},
            { 'v', "...-"},
            { 'w', ".--"},
            { 'x', "-..-"},
            { 'y', "-.--"},
            { 'z', "--.."},
            { ' ', "/"},
            { '!', "-.-.--"},
            { ',', "--..--"},
            { ':', "---..."},
            { '\'', ".----."},
            { '.', ".-.-.-"},
            { '?', "..--.."},
            { '0', "-----"},
            { '1', ".----"},
            { '2', "..---"},
            { '3', "...--"},
            { '4', "....-"},
            { '5', "....."},
            { '6', "-...."},
            { '7', "--..."},
            { '8', "---.."},
            { '9', "----."}
        };

        public  string Encode(string str)
        {
            string result = "";

            foreach(char letter in str.ToLower())
            {
                result += morse[letter] + " ";
            }

            return result.TrimEnd(' ');
        }

        public  string Decode(string str)
        {
            string result = "";

            foreach(string letter in str.Split(' '))
            {
                result += morse.FirstOrDefault(x => x.Value == letter).Key;
            }

            return result.ToUpper();
        }
    }
}
