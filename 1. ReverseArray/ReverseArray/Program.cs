using System;
using System.Linq;
using System.Text;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = GetArraySize();
            string[] inputArray = getInputArray(arraySize);
            inputArray = inputArray.Reverse().ToArray();
            string outputString = ConvertStringArrayToString(inputArray, " ");
            System.Console.WriteLine(outputString);
        }

        static string[] getInputArray(int arraySize)
        {
            string[] inputArray;

             do
            {
                inputArray = Console.ReadLine().Split(" "); 
                if (arraySize != inputArray.Length)
                {
                    System.Console.WriteLine("Declared array size is diffrent than actual array size, provide correct array");
                }
            }
            while(arraySize != inputArray.Length);
            return inputArray;

        }

        static string ConvertStringArrayToString(string[] stringArray, string separator)
        {
            StringBuilder outputString = new StringBuilder();
            foreach (var item in stringArray)
            {
                outputString.Append(item);
                outputString.Append(separator);
            }
            return outputString.ToString().TrimEnd();
        }

        static int GetArraySize()
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

    }
}
