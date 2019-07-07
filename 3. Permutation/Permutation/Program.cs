using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInputString = getInputString();
            string secondInputString = getInputString();

            int[] firstArray = parseStringToIntArray(firstInputString);
            int[] secondArray = parseStringToIntArray(secondInputString);

            bool hasPermutation = checkPermutation(firstArray, secondArray);

            string text = hasPermutation?"YES":"NO";

            Console.WriteLine(text);
        }

        static bool checkPermutation(int[] firstArray, int[] secondArray)
        {
            if(firstArray.Except(secondArray).Count()!=0)
                return false;
            else
                return true;
        }

        static int[] parseStringToIntArray(string inputString)
        {
            string[] stringArray = inputString.Split(" ");
            int[] numberArray = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                numberArray[i] = int.Parse(stringArray[i]);                
            }       
            return numberArray;            
        }

        static string getInputString()
        {
            string inputString;
            do
            {
                inputString = Console.ReadLine();
                if(!Regex.IsMatch(inputString, @"[\d ]+$") || inputString.Split(" ").Count() != 11)
                {
                    Console.WriteLine("Provide correct number array");
                }

            }while(!Regex.IsMatch(inputString, @"[\d ]+$") || inputString.Split(" ").Count()!=11);

            return inputString.TrimEnd();
        }
    }
}
