using System;

namespace P3_RectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int square = a * b;

            Console.WriteLine(square);
        }
    }
}