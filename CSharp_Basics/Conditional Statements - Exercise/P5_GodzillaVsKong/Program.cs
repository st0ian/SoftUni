using System;

namespace P5_GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());
           

            double discount = 0.0;
            double decourPrice = 0.1 * budget;

            if (statists > 150)
            {
                discount = 0.1;
            }

            double neededFunds = statists*costumePrice*(1-discount) + decourPrice;

            if (budget >= neededFunds)
            {
                Console.WriteLine($"Action!\nWingard starts filming with {string.Format("{0:0.00}", budget - neededFunds)} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!\nWingard needs {string.Format("{0:0.00}", neededFunds - budget)} leva more.");
            }
        }
    }
}
