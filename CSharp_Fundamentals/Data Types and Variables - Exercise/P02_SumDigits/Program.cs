using System;

namespace P02_SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sum = 0;

            foreach (char digit in input)
            {
                sum += int.Parse(digit.ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
