using System;

namespace P5_Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string lodging = "";
            double spentMoneyPercent = 0;

            if (budget <= 100)
            {
                location = "Bulgaria";

                if (season == "summer")
                {
                    spentMoneyPercent = 0.3;
                    lodging = "Camp";
                }
                else if (season == "winter")
                {
                    spentMoneyPercent = 0.7;
                    lodging = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                location = "Balkans";

                if (season == "summer")
                {
                    spentMoneyPercent = 0.4;
                    lodging = "Camp";
                }
                else if (season == "winter")
                {
                    spentMoneyPercent = 0.8;
                    lodging = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                location = "Europe";
                lodging = "Hotel";
                spentMoneyPercent = 0.9;
            }    
            
            double spentMoney = budget * spentMoneyPercent;
            Console.WriteLine($"Somewhere in {location}\n{lodging} - {spentMoney:f2}");
        }
    }
}
