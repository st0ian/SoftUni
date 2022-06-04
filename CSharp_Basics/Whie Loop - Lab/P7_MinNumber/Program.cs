using System;

namespace P7_MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int min = int.MaxValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int current = int.Parse(input);
                if (current < min)
                {
                    min = current;
                }
            }
            Console.WriteLine(min);
        }
    }
}
