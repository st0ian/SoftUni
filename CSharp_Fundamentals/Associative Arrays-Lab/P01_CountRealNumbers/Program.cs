using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> appearances = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNumber = numbers[i];

                if (!appearances.ContainsKey(currentNumber))
                {
                    appearances.Add(currentNumber, 1);
                }
                else
                {
                    appearances[currentNumber] += 1;
                }
            }

            foreach (var number in appearances)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }    
        }
    }
}
