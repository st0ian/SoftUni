using System;

namespace P3_CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double faren = celsius * 1.8 + 32;

            Console.WriteLine($"{faren:f2}");
        }
    }
}
