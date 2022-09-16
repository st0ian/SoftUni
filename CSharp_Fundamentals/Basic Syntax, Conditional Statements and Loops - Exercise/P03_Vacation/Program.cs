using System;

namespace P03_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            
            double price;

            switch (day)
            {
                case "Friday":
                    if (type == "Students")
                    {
                        price = 8.45;
                    }
                    if (type == "Business")
                    {
                        price = 10.90;
                    }
                    if (type == "Regular")
                    {
                        price = 15;
                    }
                    break;
                case "Sunday":
                    if (type == "Students")
                    {
                        price = 9.80;
                    }
                    if (type == "Business")
                    {
                        price = 15.60;
                    }
                    if (type == "Regular")
                    {
                        price = 20;
                    }
                    break;
                case "Saturday":
                    if (type == "Students")
                    {
                        price = 10.46;
                    }
                    if (type == "Business")
                    {
                        price = 16;
                    }
                    if (type == "Regular")
                    {
                        price = 22.50;
                    }
                    break;
                default:
                    break;
            }


        }
    }
}
