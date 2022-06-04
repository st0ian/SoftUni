using System;

namespace P9_SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string grade = Console.ReadLine();

            int nights = days - 1;
            double basePrice = 0;
            double discount = 0;
            double gradeFactor = 0;

            switch (type)
            {
                case "room for one person":
                    basePrice = 18.00;
                    break;
                case "apartment":
                    basePrice = 25.00;
                    break;
                case "president apartment":
                    basePrice = 35.00;
                    break;
            }

            if (type == "apartment")
            {
                if (nights < 10)
                {
                    discount = 0.3;
                }
                else if (nights >=10 && nights <= 15)
                {
                    discount = 0.35;
                }
                else if (nights > 15)
                {
                    discount = 0.50;
                }
            }
            else if (type == "president apartment")
            {
                if (nights < 10)
                {
                    discount = 0.1;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    discount = 0.15;
                }
                else if (nights > 15)
                {
                    discount = 0.20;
                }
            }

            if (grade == "positive")
            {
                gradeFactor = 0.25;
            }
            else if (grade == "negative")
            {
                gradeFactor = - 0.10;
            }
            double price = basePrice * (1 - discount) * nights;
            double bill = price * (1 + gradeFactor);

            Console.WriteLine($"{bill:f2}");            
        }
    }
}
