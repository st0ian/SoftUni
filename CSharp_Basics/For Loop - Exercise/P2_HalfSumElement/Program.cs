using System;

namespace P2_HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nextNum;
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                nextNum = int.Parse(Console.ReadLine());
                sum += nextNum;
                if (nextNum > max)
                {
                    max = nextNum;
                }
            }

            int difference = Math.Abs(sum - max - max);

            if (max == sum-max)
            {
                Console.WriteLine($"Yes\nSum = {max}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {difference}");
            }

        }
    }
}
