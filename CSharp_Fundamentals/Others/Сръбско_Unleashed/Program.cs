using System;
using System.Collections.Generic;
using System.Linq;

namespace Сръбско_Unleashed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lepa Brena @Sunny Beach 25 3500
            //Dragana @Sunny Beach 23 3500
            //Ceca @Belgrade 35 3500

            Dictionary<string, Dictionary<string, int>> venuesRegister =
                new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                //Ceca @Belgrade 35 3500
                //Some initial chek for invalid inputs with no spaces!!
                string[] input = command.Split('@');

                string singer = input[0].Trim();
                string[] venuInfo = input[1].Split(' ');
                string vanue;
                int ticketPrice;
                int ticketsCount;

                if (venuInfo.Length == 3)
                {
                    vanue = venuInfo[0];
                    ticketPrice = int.Parse(venuInfo[1]);
                    ticketsCount = int.Parse(venuInfo[2]);
                }
                else
                {
                    vanue = $"{venuInfo[0]} {venuInfo[1]}";
                    ticketPrice = int.Parse(venuInfo[2]);
                    ticketsCount = int.Parse(venuInfo[3]);
                }

                if (!venuesRegister.ContainsKey(vanue))
                {
                    venuesRegister.Add(vanue, new Dictionary<string, int>());
                }

                Dictionary<string, int> singersRegister = venuesRegister[vanue];
                
                if (!singersRegister.ContainsKey(singer))
                {
                    singersRegister.Add(singer, 0);
                }

                int currentProfit = CalculateProfit(ticketsCount, ticketPrice);
                singersRegister[singer] += currentProfit;
                 
                command = Console.ReadLine();
            }

            // trying to order the Register by it Value.((Key, Value).Vaue) ???
            var sortedVenuesRegister = venuesRegister.OrderBy(x => x.Value.OrderBy(y => y.Value)).ToDictionary(x => x, y => y);

            foreach (var kvp in venuesRegister)
            {
                var venueName = kvp.Key;
                Console.WriteLine($"{venueName}");

                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"#  {kvp2.Key} -> {kvp2.Value}");
                }
            }

            Console.WriteLine("The End!");
        }

        public static int CalculateProfit(int ticketsCount, int ticketPrice)
        {
            int profit = ticketsCount * ticketPrice;
            return profit;
        }
    }
}
