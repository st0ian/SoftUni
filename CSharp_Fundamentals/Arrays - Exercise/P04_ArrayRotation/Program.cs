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

            int[] currentArray = new int[input.Length];

            for (int i = 0; i < rotations; i++)
            {
                int firstEl = input[i];
                currentArray[0] = firstEl;
                for (int j = 1; j < currentArray.Length; j++)
                {
                    currentArray[j] = currentArray[j+1];
                }
                

            }

            foreach (int item in currentArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
