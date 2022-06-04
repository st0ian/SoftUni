using System;

namespace P08_NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input >= max)
                {
                    max = input;
                }
                if (input <= min)
                {
                    min = input;
                }
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
