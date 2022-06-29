using System;

namespace P3_ExcursionCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double tripBasePrice = 0;
            double coficient = 0;

            if (people <= 5)
            {
                if (season == "spring")
                {
                    tripBasePrice = 50;
                }
                else if (season == "summer")
                {
                    tripBasePrice = 48.50;
                    coficient = 0.15;
                }
                else if (season == "autumn")
                {
                    tripBasePrice = 60;
                }
                else
                {
                    tripBasePrice = 86;
                    coficient = -0.08;
                }
            }
            else
            {
                if (season == "spring")
                {
                    tripBasePrice = 48;
                }
                else if (season == "summer")
                {
                    tripBasePrice = 45;
                    coficient = 0.15;
                }
                else if (season == "autumn")
                {
                    tripBasePrice = 49.50;
                }
                else
                {
                    tripBasePrice = 85;
                    coficient = -0.08;
                }
            }

            double tripTotalFinalPrice = people * tripBasePrice * (1 - coficient);
            Console.WriteLine($"{tripTotalFinalPrice:f2} leva.");
        }
    }
}
