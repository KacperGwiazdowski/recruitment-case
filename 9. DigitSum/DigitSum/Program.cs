using System;
using System.Text.RegularExpressions;

namespace DigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = getArraySize();
            string[] inputArray = getInputArray(arraySize);
            int sum = getDigitSum(inputArray);
            Console.WriteLine(sum);

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
                
            } while (!isNumberCorrect);           
           return arraySize;            
        }
         static string[] getInputArray(int arraySize)
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
            return inputArray;
        }
         static int getDigitSum(string[] inputArray)
         {
             int biggestSum = 0;
             foreach (var number in inputArray)
             {
                 int sum = 0;
                 foreach (var item in number)
                 {
                     sum = sum + int.Parse(item.ToString());
                 }
                
                if(sum>biggestSum)
                    biggestSum = sum;
             }
             return biggestSum;
         }
    }
}
