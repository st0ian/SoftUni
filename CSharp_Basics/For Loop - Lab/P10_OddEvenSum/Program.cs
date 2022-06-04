using System;

namespace P10_OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;            

            for (int position = 0; position < num; position++)
            {
                int input = int.Parse(Console.ReadLine());
                if (position % 2 == 0)
                {
                    evenSum += input;
                }
                else 
                {
                    oddSum += input;
                }
            }

            bool equal = evenSum == oddSum;
            int difference = Math.Abs(evenSum - oddSum);

            if (equal)
            {
                Console.WriteLine($"Yes\nSum = {evenSum}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {difference}");
            }
        }
    }
}
