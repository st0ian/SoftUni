using System;

namespace P8_CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;
            double circumference = 2 * Math.PI * r;

            Console.WriteLine($"{area:f2}\n{circumference:f2}");
        }
    }
}
