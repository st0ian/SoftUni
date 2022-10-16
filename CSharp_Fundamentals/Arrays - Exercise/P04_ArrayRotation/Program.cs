using System;
using System.Linq;

namespace P04_ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int swaps = 0; swaps < rotations; swaps++)
            {
                int firstEl = input[0];

                for (int position = 0; position < input.Length-1; position++)
                {
                    input[position] = input[position + 1];
                }

                input[input.Length-1] = firstEl;

            }

            foreach (int item in input)
            {
                Console.Write(item + " ");
            }
        }
    }
}
