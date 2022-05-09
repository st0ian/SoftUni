using System;

namespace P7_FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalChickens = int.Parse(Console.ReadLine());
            int totalFishes = int.Parse(Console.ReadLine());
            int totalVeggies = int.Parse(Console.ReadLine());

            const double priceOfChicken = 10.35;
            const double priceOfFish = 12.40;
            const double priceOfVeggie = 8.15;
            const double priceOfDelivery = 2.5;
            double billDessert;

            double billChickens = totalChickens * priceOfChicken;
            double billFishes = totalFishes * priceOfFish;
            double billVeggies = totalVeggies * priceOfVeggie;
            billDessert = (billChickens + billFishes + billVeggies) * 0.2;

            double totalBill = billChickens + billFishes + billVeggies + billDessert + priceOfDelivery;

            Console.WriteLine(totalBill);
        }
    }
}