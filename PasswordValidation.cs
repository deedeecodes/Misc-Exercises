using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace IttyBittyProblems
{
    public class PasswordValidation
    {
        /* 
         In this project you’ll make a program that measures the strength of any given password based on the following criteria. A strong password:
         The program will ask the user to input a password, and using conditional logic and control flow, it will rate the password.
         I didn't include the details as it is part of a paid subscription :)
         From: https://codecademy.com/ Course C# Pro: Logic and Conditionals
         */

        public int[] PasswordCheck(string password)
        {
            int[] scoreAndTips = new int[6];

            List<string> pattern = new List<string>(){
                @".{8,}",
                @"[a-z]",
                @"[A-Z]",
                @"[0-9]",
                @"[\W]"
            };

            if (password == "password" || password == "1234" || password.Count(x => x == ' ') == password.Length)
            {
                return scoreAndTips;
            }
            else
            {
                for (int i = 0; i < pattern.Count; i++)
                {
                    if (Regex.IsMatch(password, pattern[i]))
                    {
                        scoreAndTips[0]++;
                        scoreAndTips[i + 1] = 1;
                    }
                }
            }

            return scoreAndTips;
        }

        public string IsValid(string password)
        {
            List<string> tips = new List<string>(){
                " -> adding more characters",
                " -> adding lowercase letters",
                " -> adding uppercase letters",
                " -> adding numbers",
                " -> adding symbols"
            };

            int[] scoreAndTips = PasswordCheck(password);

            Console.Write($"Your password has a score of {scoreAndTips[0]}/5 and is  ");
            switch (scoreAndTips[0])
            {
                case 1:
                    Console.Write("weak! ");
                    return "Weak!";
                    break;
                case 2:
                    Console.Write("medium! ");
                    return "Medium!";
                    break;
                case 3:
                    Console.Write("strong! ");
                    return "Strong!";
                    break;
                case 4:
                case 5:
                    Console.Write("extremely strong! ");
                    return "Extremely Strong!";
                    break;
                default:
                    Console.Write("terrible! ");
                    return "Terrible!";
                    break;
            }

            if (scoreAndTips[0] < 5)
            {
                Console.WriteLine("You can improve it by: ");
                for (int i = 0; i < tips.Count; i++)
                {
                    if (scoreAndTips[i + 1] == 0)
                    {
                        Console.WriteLine(tips[i]);
                    }
                }
            }
        }
    }
}