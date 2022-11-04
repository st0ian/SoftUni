using System;
using System.Collections.Generic;

namespace P02_OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Dictionary<string, int> collection = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string currentInput = input[i].ToLower();

                if (!collection.ContainsKey(currentInput))
                {
                    collection.Add(currentInput, 1);
                }
                else
                {
                    collection[currentInput]++;
                }
            }

            foreach (var item in collection)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
