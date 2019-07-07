using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FindingPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTest = getNumberOfTestCases();
            List<TestCase> testList = getTestCases(numberTest);
            foreach (var item in testList)
            {
                Console.WriteLine(item.CalculatePrimeNumbersAmount());
            }
        }

        static int getNumberOfTestCases()
        {
            while(true)
            {
                string input = Console.ReadLine();
                if(Regex.IsMatch(input,@"^[\d]+$"))
                    return int.Parse(input);
                else
                    Console.WriteLine("Provice correct data");
            }
        }

        static List<TestCase> getTestCases(int numberOfTestCases)
        {
            Console.WriteLine("Type test data, two numbers per line");
            List<TestCase> testList = new List<TestCase>();
            for(int i = 0; i<numberOfTestCases; i++)
            {
                bool correctInput = false;;

  
                while (!correctInput)
                {
                     string input = Console.ReadLine();
                     if (Regex.IsMatch(input, @"^[\d]+ [\d]+$"))
                    {
                        string[] inuputStringArray = input.Split(" ");
                        testList.Add(
                            new TestCase(
                                int.Parse(inuputStringArray[0]),
                                int.Parse(inuputStringArray[1])
                            )
                        );
                   
                        correctInput = true;
                    } else 
                    {
                        Console.WriteLine("Provide correct input");
                        correctInput = false;
                    }
                        
                }
              
                
            }
            return testList;
        }
    }
}
