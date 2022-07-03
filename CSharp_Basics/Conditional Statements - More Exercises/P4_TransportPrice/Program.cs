using System;

namespace P4_TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            double priceTaxi = 0.70;
            double priceBus = double.MaxValue;
            double priceTrain = double.MaxValue;

            if (dayTime == "day")
            {
                priceTaxi += 0.79 * distance;

                if (distance >= 20)
                {
                    priceBus = 0.09 * distance;
                }
                if (distance >= 100)
                {
                    priceTrain = 0.06 * distance;
                }
            }
            else if (dayTime == "night")
            {
                priceTaxi += 0.9 * distance; 

                if (distance >= 20)
                {
                    priceBus = 0.09 * distance;
                }
                if (distance >= 100)
                {
                    priceTrain = 0.06 * distance;
                }
            }

            if (priceTaxi < priceBus && priceTaxi < priceTrain)
            {
                Console.WriteLine($"{priceTaxi:f2}");
            }
            else if (priceBus < priceTrain && priceBus < priceTaxi)
            {
                Console.WriteLine($"{priceBus:f2}");
            }
            else
            {
                Console.WriteLine($"{priceTrain:f2}");
            }
        }
    }
}
