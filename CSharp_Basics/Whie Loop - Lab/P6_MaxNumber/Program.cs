using System;

namespace P6_MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int biggest = int.MinValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int number = int.Parse(input);
                if (number > biggest)
                {
                    biggest = number;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
