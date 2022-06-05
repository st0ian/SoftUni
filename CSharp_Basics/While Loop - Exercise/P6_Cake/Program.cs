using System;

namespace P6_Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine())/100;

            Console.WriteLine($"{Math.Round(change, 4):f5}");
            Console.WriteLine(change);
        }
    }
}
