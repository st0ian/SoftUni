using System;

namespace P7_HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double priceAppartment = 0;
            double priceStudio = 0;
            double discountAppartment = 0;
            double discountStudio = 0;

            switch (month)
            {
                case "May":
                case "October":                    
                    priceStudio = 50;
                    priceAppartment = 65;
                    break;
                case "June":
                case "September":                    
                    priceStudio = 75.20;
                    priceAppartment = 68.70;
                    break;
                case "July":
                case "August":
                    priceStudio = 76;
                    priceAppartment = 77;                    
                    break;
            }

            if (days > 7 && (month == "May" || month == "October"))
            {
                discountStudio = 0.05;
            }
            if (days > 14)
            {
                discountAppartment = 0.1;

                if (month == "May" || month == "October")
                {
                    discountStudio = 0.3;
                }
                else if (month == "June" || month == "September")
                {
                    discountStudio = 0.2;
                }
            }
            double appartment = days * priceAppartment * (1 - discountAppartment);       
            double studio = days * priceStudio * (1 - discountStudio);

            Console.WriteLine($"Apartment: {appartment:f2} lv.\nStudio: {studio:f2} lv.");
        }
    }
}
