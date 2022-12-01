using System;
using System.Collections.Generic;

namespace P07_AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);            

            List<string> result = new List<string>();

            string tempString = string.Empty;

            for (int i = input.Length-1; i >= 0; i--)
            {
               tempString += input[i];                
            }

            bool hasMinus = false;

            for (int i = 0; i < tempString.Length; i++)
            {
                char curchar = tempString[i];

                if (curchar == 32)
                {
                    continue;
                }

                if (curchar == 45)
                {
                    hasMinus = true;
                    continue;
                }

                if (curchar >= 48 && curchar <= 57 || curchar == 45)
                {
                    string temp = curchar.ToString();

                    if (hasMinus)
                    {
                        temp = temp.Insert(0, "-");
                    }

                    result.Add(temp);
                }

                hasMinus = false;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
