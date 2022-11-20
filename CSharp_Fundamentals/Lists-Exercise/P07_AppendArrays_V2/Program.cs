using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_AppendArrays_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            string temp = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {

                temp += input[i].Replace(" ", "");

            }

            List<char> list = temp.ToList();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
