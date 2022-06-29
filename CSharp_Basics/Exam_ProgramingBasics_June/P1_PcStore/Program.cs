using System;

namespace P1_PcStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceCpu = double.Parse(Console.ReadLine());
            double priceVideo = double.Parse(Console.ReadLine());
            double priceRam = double.Parse(Console.ReadLine());
            int piecesRam = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double totalPriceUsd = priceCpu * (1 - discount) + priceVideo * (1 - discount) + priceRam * piecesRam;
            double totlaPriceBgn = totalPriceUsd * 1.57;

            Console.WriteLine($"Money needed - {totlaPriceBgn:f2} leva.");
        }
    }
}
