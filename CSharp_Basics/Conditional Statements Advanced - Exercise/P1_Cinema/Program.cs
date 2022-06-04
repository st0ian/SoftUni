using System;

namespace P1_Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string evetType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int collumns = int.Parse(Console.ReadLine());

            double price = 0;
            switch (evetType)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5;
                    break;
            }

            int capacity = rows * collumns;
            double income = capacity * price;
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
