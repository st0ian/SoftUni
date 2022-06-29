using System;

namespace P5_ExcursionSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seaTrips = int.Parse(Console.ReadLine());
            int mountainTrips = int.Parse(Console.ReadLine());

            int seaTripPrice = 680;
            int mountainTripPrice = 499;

            int income = 0;
            bool allSold = false;

            string input = Console.ReadLine();

            while (input != "Stop")
            {

                if (input == "sea")
                {
                    if (seaTrips > 0)
                    {
                        income += seaTripPrice;
                    }
                    seaTrips--;
                }
                else if (input == "mountain")
                {
                    if (mountainTrips > 0)
                    {
                        income += mountainTripPrice;
                    }
                    mountainTrips--;
                }
                if (seaTrips <= 0 && mountainTrips <= 0)
                {
                    allSold = true;
                    break;
                }

                input = Console.ReadLine();
            }

            if (allSold)
            {
                Console.WriteLine($"Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {income} leva.");
        }
    }
}
