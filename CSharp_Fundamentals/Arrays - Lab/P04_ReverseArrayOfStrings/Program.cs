using System;
using System.Linq;

namespace P04_ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string[] reversedInput = new string[input.Length];

            for (int i = 0; i < reversedInput.Length; i++)
            {
                reversedInput[i] = input[input.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", reversedInput));
        }
    }
}
