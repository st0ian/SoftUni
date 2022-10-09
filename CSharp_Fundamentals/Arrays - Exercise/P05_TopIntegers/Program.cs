using System;
using System.Linq;

namespace P05_TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            bool isTop = true;

            for (int i = 0; i < input.Length; i++)
            {
                int currentEl = input[i];

                for (int j = i+1; j < input.Length; j++)
                {
                    if (currentEl <= input[j])
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    Console.Write(currentEl + " ");
                }

                isTop = true;
            }
        }
    }
}
