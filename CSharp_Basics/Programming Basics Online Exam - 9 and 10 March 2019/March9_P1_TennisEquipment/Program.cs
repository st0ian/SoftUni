using System;

namespace March9_P1_TennisEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rocketPrice = double.Parse(Console.ReadLine());
            int rockets = int.Parse(Console.ReadLine());
            int snickers = int.Parse(Console.ReadLine());

            double snickersPrice = rocketPrice / 6;
            double priceRocketsAndSnickers = rockets * rocketPrice + snickers * snickersPrice;
            double additionalEquipment = priceRocketsAndSnickers * 0.2;

            double totalPrice = priceRocketsAndSnickers + additionalEquipment;
            double expensePlayer = Math.Floor(totalPrice / 8);
            double expenseSponsors = Math.Ceiling(totalPrice * 7 / 8);

            Console.WriteLine($"Price to be paid by Djokovic {expensePlayer}\n" +
                $"Price to be paid by sponsors {expenseSponsors}");
        }
    }
}
