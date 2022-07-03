using System;

namespace P6_FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnoles = int.Parse(Console.ReadLine());
            int zumbules = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double priceMagnoles = 3.25;
            double priceZumbules = 4;
            double priceRoses = 3.50;
            double priceCactuses = 8;

            double taxes = 0.05;

            double income = magnoles * priceMagnoles + zumbules * priceZumbules + roses * priceRoses + cactuses * priceCactuses;
            double incomeAfterTaxes = income * (1 - taxes);

            double difference = Math.Abs(incomeAfterTaxes - presentPrice);

            if (incomeAfterTaxes >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(difference)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(difference)} leva.");
            }
        }
    }
}
