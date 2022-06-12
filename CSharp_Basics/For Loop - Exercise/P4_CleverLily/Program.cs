using System;

namespace P4_CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWasher = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int toys = 0;
            int savings = 0;
            int birthdayMoney = 10;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savings += birthdayMoney;
                    birthdayMoney += 10;
                    savings--;
                }
                else
                {
                    toys++;
                }
            }
            double savedMoney = savings + toys * priceToy;
            double difference = savedMoney - priceWasher;

            if (difference >= 0)
            {
                Console.WriteLine($"Yes! {difference:f2}");
            }
            else
            {
                Console.WriteLine($"No! {-difference:f2}");
            }
        }
    }
}
