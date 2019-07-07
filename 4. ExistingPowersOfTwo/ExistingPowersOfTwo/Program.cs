using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace ExistingPowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] data = getInputData();
            uint biggestTwoPow = findBiggestPowOfTwo(data);
            string text = getOutputArrayString(biggestTwoPow);
            System.Console.WriteLine(text);
        }

        static uint[] getInputData()
        {
            List<uint> inputData = new List<uint>();
            bool quitFlag = true;
            Console.WriteLine("Provide data, type q to end");
            while(quitFlag)
            {
                string num = Console.ReadLine();
                if(num.Equals("q"))
                    break;

                try
                {
                    inputData.Add(uint.Parse(num));
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Provide correct data");
                }
            }
            return inputData.ToArray();
        }

        static string getOutputArrayString(uint number)
        {
            System.Console.WriteLine(number);
            if(number==0)
                return "NA";
            else if( number ==1)
                return "1";

            StringBuilder builder = new StringBuilder();
            int i =0;
            while(true)
            {
                uint pow = (uint) Math.Pow(2,i);
                builder.Append(pow);
                builder.Append(",");
                i++;
                if(pow==number)
                    break;
            }
            return builder.ToString().TrimEnd(',');
        }

        static uint findBiggestPowOfTwo(uint[] numbers)
        {
            numbers = numbers.OrderByDescending(a =>a).ToArray();
            foreach (var item in numbers)
            {
                if(checkIfPowTwo(item))
                    return item;
            }

            return 0;
        }

        static bool checkIfPowTwo(uint num)
        {
            return (num != 0) && ((num & (num - 1)) == 0);
        }
    }
}
