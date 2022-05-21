using System;

namespace P5_SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());

            decimal localPrice = 0.00m;

            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    localPrice = 0.50m;
                }
                else if (city == "Plovdiv")
                {
                    localPrice = 0.40m;
                }
                else if (city == "Varna")
                {
                    localPrice = 0.45m;
                }                
            }
            else if (product == "water")
            {
                if (city == "Sofia")
                {
                    localPrice = 0.80m;
                }
                else if (city == "Plovdiv")
                {
                    localPrice = 0.70m;
                }
                else if (city == "Varna")
                {
                    localPrice = 0.70m;
                }
            }
            else if (product == "beer")
            {
                if (city == "Sofia")
                {
                    localPrice = 1.20m;
                }
                else if (city == "Plovdiv")
                {
                    localPrice = 1.15m;
                }
                else if (city == "Varna")
                {
                    localPrice = 1.10m;
                }
            }
            else if (product == "sweets")
            {
                if (city == "Sofia")
                {
                    localPrice = 1.45m;
                }
                else if (city == "Plovdiv")
                {
                    localPrice = 1.30m;
                }
                else if (city == "Varna")
                {
                    localPrice = 1.35m;
                }
            }
            else if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    localPrice = 1.60m;
                }
                else if (city == "Plovdiv")
                {
                    localPrice = 1.50m;
                }
                else if (city == "Varna")
                {
                    localPrice = 1.55m;
                }
            }

            Console.WriteLine(quantity * localPrice);
        }
    }
}
