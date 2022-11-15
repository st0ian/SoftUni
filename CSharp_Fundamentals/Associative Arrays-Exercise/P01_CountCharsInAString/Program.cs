using System;
using System.Collections.Generic;

namespace P01_CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace(" ", "");

            Dictionary<char, int> counter= new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentCh = input[i];

                if (!counter.ContainsKey(currentCh))
                {
                    counter.Add(currentCh, 0);
                }

                counter[currentCh]++;
            }

            foreach (var kvp in counter)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
