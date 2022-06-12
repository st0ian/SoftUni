using System;

namespace P5_Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            while (input != "End")
            {
                double cost = double.Parse(Console.ReadLine());
                double sum = 0;
                while (sum < cost)
                {
                    double nextSave = double.Parse(Console.ReadLine());
                    sum += nextSave;
                }
                Console.WriteLine($"Going to {input}!");
                input = Console.ReadLine();
            }
        }
    }
}