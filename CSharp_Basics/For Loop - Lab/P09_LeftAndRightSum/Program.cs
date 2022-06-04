using System;

namespace P09_LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < num*2; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (i < num)
                {
                    leftSum += input;
                }
                else if (i >= num)
                {
                    rightSum += input;
                }
            }

            bool equal = leftSum == rightSum;
            int difference = Math.Abs(leftSum - rightSum);

            if (equal)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
