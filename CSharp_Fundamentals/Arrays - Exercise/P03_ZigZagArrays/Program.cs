using System;
using System.Linq;

namespace P03_ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                int firstNumber = numbers[0];
                int secondNumber = numbers[1];

                if (i%2 != 0)
                {
                    firstArray[i - 1] = firstNumber;
                    secondArray[i - 1] = secondNumber;
                        
                }
                else
                {
                    firstArray[i - 1] = secondNumber;
                    secondArray[i - 1] = firstNumber;
                }
            }

            Console.WriteLine(String.Join(" ", firstArray));
            Console.WriteLine(String.Join(" ", secondArray));
        }
    }
}
