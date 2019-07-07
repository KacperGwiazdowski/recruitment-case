using System;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            inputString = validateInput(inputString);
            bool isPalindrome = checkIfPalindrome(inputString);
            string text = isPalindrome?"YES":"NO";
            System.Console.WriteLine(text);
        }

        static string validateInput(string input)
        {
            return Regex.Replace(input, "[^a-zA-Z]", "").ToLower();
        }

        static bool checkIfPalindrome(string inputString)
        {
             for(int i = 0, j = inputString.Length-1; i<inputString.Length; i++, j--)
            {
                if(inputString[i] != inputString[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
