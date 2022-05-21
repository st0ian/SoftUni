using System;

namespace P12_TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double comission = 0;

            if (city == "Sofia")
            {
                if (amount >= 0 && amount <= 500)
                {
                    comission = 5;
                }
                else if (amount > 500 && amount <= 1000)
                {
                    comission = 7;
                }
                else if (amount > 1000 && amount <= 10000)
                {
                    comission = 8;
                }
                else if (amount > 10000)
                {
                    comission = 12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (amount >= 0 && amount <= 500)
                {
                    comission = 4.5;
                }
                else if (amount > 500 && amount <= 1000)
                {
                    comission = 7.5;
                }
                else if (amount > 1000 && amount <= 10000)
                {
                    comission = 10;
                }
                else if (amount > 10000)
                {
                    comission = 13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (amount >= 0 && amount <= 500)
                {
                    comission = 5.5;
                }
                else if (amount > 500 && amount <= 1000)
                {
                    comission = 8;
                }
                else if (amount > 1000 && amount <= 10000)
                {
                    comission = 12;
                }
                else if (amount > 10000)
                {
                    comission = 14.5;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            if (comission > 0)
            {
                double traderComission = amount * comission/100;
                Console.WriteLine($"{traderComission:F2}");
            }
        }
    }
}
