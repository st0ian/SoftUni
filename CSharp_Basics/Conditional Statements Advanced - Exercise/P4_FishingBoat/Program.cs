using System;

namespace P4_FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            int rentBasePrice = 0;
            double discount = 0;
            double additionalDiscount = 0;

            bool isFishermenEven = fishermen % 2 == 0;

            switch (season)
            {
                case "Spring":
                    rentBasePrice = 3000;
                    break;
                case "Summer":
                    rentBasePrice = 4200;
                    break;
                case "Autumn":
                    rentBasePrice = 4200;
                    break;
                case "Winter":
                    rentBasePrice = 2600;
                    break;
            }

            if (fishermen <= 6)
            {
                discount = 0.10;
            }
            else if (fishermen > 6 && fishermen <= 11)
            {
                discount = 0.15;
            }
            else if (fishermen > 11)
            {
                discount = 0.25;
            }

            if (isFishermenEven && season != "Autumn")
            {
                additionalDiscount = 0.05;
            }

            double rentPrice = rentBasePrice * (1 - discount) * (1 - additionalDiscount);
            double difference = budget - rentPrice;

            if (budget >= rentPrice)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(rentPrice - budget):f2} leva.");
            }
        }
    }
}
