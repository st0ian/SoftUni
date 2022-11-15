using System;
using System.Collections.Generic;

namespace P02_AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> minersResources = new Dictionary<string, int>();
            string currentResource = string.Empty;
            bool oddRowInput = true;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                if (oddRowInput)
                {
                    currentResource = input;
                    if (!minersResources.ContainsKey(currentResource))
                    {
                        minersResources.Add(currentResource, 0);
                    }

                    oddRowInput = false;
                    continue;
                }

                int resourceAmount = int.Parse(input);
                minersResources[currentResource] += resourceAmount;
                oddRowInput = true;
            }

            foreach (var item in minersResources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
