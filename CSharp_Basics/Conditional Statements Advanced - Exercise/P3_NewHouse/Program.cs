using System;

namespace P3_NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;
            double priceModifier = 0;

            switch (flowerType)
            {
                case "Roses":
                    price = 5;
                    break;
                case "Dahlias":
                    price = 3.8;
                    break;
                case "Tulips":
                    price = 2.8;
                    break;
                case "Narcissus":
                    price = 3;
                    break;
                case "Gladiolus":
                    price = 2.5;
                    break;
            }

            if (flowerType == "Roses" && flowers > 80)
            {
                priceModifier = 0.10;
            }
            else if (flowerType == "Dahlias" && flowers > 90)
            {
                priceModifier = 0.15;
            }
            else if (flowerType == "Tulips" && flowers > 80)
            {
                priceModifier = 0.15;
            }
            else if (flowerType == "Narcissus" && flowers < 120)
            {
                priceModifier = -0.15;

            }
            else if (flowerType == "Gladiolus" && flowers < 80)
            {
                priceModifier = -0.20;
            }

            double bill = flowers * price * (1 - priceModifier);
            double difference = Math.Abs(budget - bill);

            if (budget >= bill)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowers} {flowerType} and {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
            }
        }
    }
}
