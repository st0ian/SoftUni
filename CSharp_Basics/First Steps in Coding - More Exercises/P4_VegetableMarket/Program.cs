using System;

namespace P4_VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int vegetablesKgs = int.Parse(Console.ReadLine());
            int fruitsKgs = int.Parse(Console.ReadLine());

            double sumBgn = priceVegetables * vegetablesKgs + priceFruits * fruitsKgs;
            double sumEu = sumBgn / 1.94;

            Console.WriteLine($"{sumEu:f2}");
        }
    }
}
