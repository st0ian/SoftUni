using System;
using System.Linq;

namespace P03_HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            int curIndex = 0;
            while (command != "Love!")
            {
                string[] jump = command.Split().ToArray();
                int distance = int.Parse(jump[1]);

                // if jump > length --- index =0
                if (distance > input.Length - 1)
                {
                    curIndex = 0;
                }

                int nextIndex = curIndex + distance;

                // if nextIndex > length --- index =0
                if (nextIndex > input.Length - 1)
                {
                    nextIndex = 0;
                    curIndex = 0;
                }
                else
                {
                    curIndex = nextIndex;
                }

                if (input[curIndex] > 0)
                {
                    input[curIndex] -= 2; 
                    if (input[curIndex] <= 0)
                    {
                        Console.WriteLine($"Place {curIndex} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {curIndex} already had Valentine's day.");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {curIndex}.");

            bool isSuccess = true;
            int count = 0;

            foreach (int house in input)
            {
                if (house != 0)
                {
                    isSuccess = false;
                    count++;
                }
            }

            if (isSuccess)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {count} places.");
            }
        }
    }
}
