using System;

namespace P8__FuelTankPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            string hasCard = Console.ReadLine();

            double priceGasoline = 2.22;
            double priceDisel = 2.33;
            double priceGas = 0.93;

            double gasolineCardDiscount = 0;
            double diselCardDiscount = 0;
            double gasCardDiscount = 0;

            if (hasCard == "Yes")
            {
                gasolineCardDiscount = 0.18;
                diselCardDiscount = 0.12;
                gasCardDiscount = 0.08;
            }

            double price = 0;
            double discount = 0;

            if (fuelType == "Gasoline")
            {
                if (volume >= 20 && volume <= 25)
                {
                    discount = 0.08;
                }
                else if (volume > 25)
                {
                    discount = 0.10;
                }
                price = volume * (priceGasoline - gasolineCardDiscount) * (1 - discount);
            }
            else if (fuelType == "Diesel")
            {
                if (volume >= 20 && volume <= 25)
                {
                    discount = 0.08;
                }
                else if (volume > 25)
                {
                    discount = 0.10;
                }
                price = volume * (priceDisel - diselCardDiscount) * (1 - discount);
            }
            else if (fuelType == "Gas")
            {
                if (volume >= 20 && volume <= 25)
                {
                    discount = 0.08;
                }
                else if (volume > 25)
                {
                    discount = 0.10;
                }
                price = volume * (priceGas - gasCardDiscount) * (1 - discount);
            }

            Console.WriteLine($"{price:f2} lv.");      
        }
    }
}
