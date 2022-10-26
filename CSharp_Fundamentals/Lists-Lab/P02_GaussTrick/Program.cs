using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int iterations = input.Count / 2;

            for (int i = 0; i < iterations; i++)
            {
                input[i] = input[i] + input[input.Count - 1];
                input.RemoveAt(input.Count - 1);
            }

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
