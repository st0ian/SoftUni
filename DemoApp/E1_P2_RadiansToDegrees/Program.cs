using System;

namespace MyApp
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = 180 * radians / Math.PI;

            Console.WriteLine(degrees);
        }
    }
}