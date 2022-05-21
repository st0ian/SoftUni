using System;

namespace P7_Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videoCardPrice = 250;
            double discount = 0;

            double videoCardsTotalPrice = videoCards * videoCardPrice;
            double processorsTotalPrice = processors * 0.35 * videoCardsTotalPrice;
            double ramTotalPrice = ram * 0.1 * videoCardsTotalPrice;

            if (videoCards>processors)
            {
                discount = 0.15;
            }

            double bill = (videoCardsTotalPrice + processorsTotalPrice + ramTotalPrice) * (1 - discount);

            if (bill <= budget)
            {
                Console.WriteLine($"You have {string.Format("{0:0.00}", budget - bill)} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {string.Format("{0:0.00}", bill - budget)} leva more!");
            }
        }
    }
}
