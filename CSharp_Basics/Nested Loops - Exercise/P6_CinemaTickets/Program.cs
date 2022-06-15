using System;

namespace P6_CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            int totalTickets = 0;
            int kidTickets = 0;
            int studentTickets = 0;
            int standartTickets = 0;

            while (command != "Finish")
            {
                command = Console.ReadLine();
                if (command == "Finish")
                {
                    break;
                }

                string movie = command;
                string entranceType = "";

                int capacity = int.Parse(Console.ReadLine());
                int visitors = 0;

                while (entranceType != "End")
                {
                    entranceType = Console.ReadLine();
                    if (entranceType == "End")
                    {
                        break;
                    }

                    switch (entranceType)
                    {
                        case "kid":
                            kidTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                        case "standard":
                            standartTickets++;
                            break;
                        default:
                            break;
                    }

                    visitors++;

                    if (capacity == visitors)
                    {
                        break;
                    }
                }

                totalTickets += visitors;
                double capacityPercentage = ((double)visitors / capacity) * 100;
                Console.WriteLine($"{movie} - {capacityPercentage:f2}% full.");
            }

            double kidTicketsPercentage = ((double)kidTickets / totalTickets) * 100;
            double studentTicketsPercentage = ((double)studentTickets / totalTickets) * 100;
            double standartTicketsPercentage = ((double)standartTickets / totalTickets) * 100;

            Console.WriteLine($"Total tickets: {totalTickets}\n{studentTicketsPercentage:f2}% student tickets.\n{standartTicketsPercentage:f2}% standard tickets.\n{kidTicketsPercentage:f2}% kids tickets.");
        }
    }
}
