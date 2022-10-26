using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ........ 75 / 100 points
            string[] input = Console.ReadLine().Split("|");            

            List<char> result = new List<char>();

            string tempString = string.Empty;

            for (int i = input.Length-1; i >= 0; i--)
            {
               tempString += input[i];                
            }

            for (int i = 0; i < tempString.Length; i++)
            {
                char curchar = tempString[i];

                if (curchar >= 48 && curchar <= 57)
                {
                    result.Add(curchar);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
