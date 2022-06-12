using System;

namespace P1_Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h < 24; h++)
            {
                for (int min = 0; min < 60; min++)
                {
                    Console.WriteLine($"{h}:{min}");
                }
            }
        }
    }
}
