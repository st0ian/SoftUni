using System;
using System.Linq;

namespace P06_EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                  .Split(' ')
                                  .Select(int.Parse)
                                  .ToArray();

            if (input.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            int currentNum;
            int leftSum;
            int rightSum;

            for (int i = 0; i < input.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                currentNum = input[i];

                for (int j = 0; j < i; j++)
                {
                    leftSum += input[j];
                }

                for (int j = i+1; j < input.Length; j++)
                {
                    rightSum += input[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }                
            }

            Console.WriteLine("no");
        }
    }
}
