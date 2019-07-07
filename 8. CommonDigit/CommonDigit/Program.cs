using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace CommonDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = getArraySize();
            string inputString = getInputArray(arraySize); 
            string text = getMostOccurences(inputString);
            Console.WriteLine(text);
            
        }

         static int getArraySize()
        {
            bool isNumberCorrect = true;
            int arraySize=0;
            do
            {
                try
                {
                    arraySize = int.Parse(Console.ReadLine());
                    isNumberCorrect = true;
                }
                catch (System.Exception)
                {
                    
                    isNumberCorrect = false;
                    System.Console.WriteLine("Provide correct number");
                }

                if(!(arraySize>=2 && arraySize<=20))
                {
                    isNumberCorrect = false;
                    System.Console.WriteLine("Provide correct number 2-20");
                }
                
            } while (!isNumberCorrect);           
           return arraySize;            
        }
         static string getInputArray(int arraySize)
        {
            string inputString;
            string[] inputArray;
            bool correctArray = true;

             do
            {
                inputString=Console.ReadLine();
                inputArray = inputString.Split(" "); 
                if (arraySize != inputArray.Length)
                {
                    Console.WriteLine("Declared array size is diffrent than actual array size, provide correct array");
                    correctArray = false;
                }

                if(!Regex.IsMatch(inputString,@"[\d ]+"))
                {
                    Console.WriteLine("Provide correct array");
                    correctArray = false;
                }
            }
            while(!correctArray);
            return inputString;
        }

        static string getMostOccurences(string inputArray)
        {
            Dictionary<char, int> occurences = new Dictionary<char, int>();
            inputArray = inputArray.Replace(" ", "");
            var keys = inputArray.Distinct();
            foreach (var item in keys)
            {
                occurences.Add(item, 0);
            }
            foreach (var item in inputArray)
            {
                occurences[item]++;
            }
            var maxValue = occurences.Max(a => a.Value);
            var maxOccurences = occurences.Where(i => i.Value == maxValue);
            int biggestKey = 0;
            foreach (var item in maxOccurences)
            {

                var value = int.Parse(item.Key.ToString());
                if(value>biggestKey)
                    biggestKey = value;
            }
            return biggestKey.ToString();
        }
    }
}
