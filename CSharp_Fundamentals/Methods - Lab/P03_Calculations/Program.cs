using System;

namespace P03_Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            calculate(command, numberA, numberB);
        }

        private static void calculate(string command, int a, int b)
        {
            double result = default;

            switch (command)
            {
                case "add":
                    result = a + b;
                    break;
                case "multiply":
                    result = a * b;
                    break;
                case "subtract":
                    result = a - b;
                    break;
                case "divide":
                    result = a / b;
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
