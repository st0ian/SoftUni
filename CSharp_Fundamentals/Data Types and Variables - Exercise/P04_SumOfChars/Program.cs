using System;

namespace P04_SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char nextLetter = char.Parse(Console.ReadLine());
                sum += (int)nextLetter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
