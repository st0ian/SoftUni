using System;

namespace P5_SuppliesForSchool
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int packsOfPens = int.Parse(Console.ReadLine());
            int packsOfMarkers = int.Parse(Console.ReadLine());
            int litersCleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            const double priceOfPens = 5.80;
            const double priceOfMarkers = 7.20;
            const double priceOfLiterCleaner = 1.20;

            double priceTotalPens = packsOfPens * priceOfPens;
            double priceTotalMarkers = packsOfMarkers * priceOfMarkers;
            double priceTotalCleaner = litersCleaner * priceOfLiterCleaner;

            double bill = priceTotalPens + priceTotalMarkers + priceTotalCleaner;
            double billWithDiscount = bill * (100 - discount) / 100;

            Console.WriteLine(billWithDiscount);
        }
    }
}