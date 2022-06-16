using System;

namespace P6_Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double skumriyaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKgs = double.Parse(Console.ReadLine());
            double safridKgs = double.Parse(Console.ReadLine());
            double midiKgs = double.Parse(Console.ReadLine());

            double palamudPriceKg = skumriyaPrice * 1.6;
            double safridPriceKg = cacaPrice * 1.8;
            double midiPriceKg = 7.50;

            double totalPrice = palamudKgs * palamudPriceKg + safridKgs * safridPriceKg + midiKgs * midiPriceKg;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
