using System;

namespace P2_MaidenParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            int loveLetters = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keyholders = int.Parse(Console.ReadLine());
            int paintings = int.Parse(Console.ReadLine());
            int surprizes = int.Parse(Console.ReadLine());

            double loveLettersPrice = 0.60;
            double rosesPrice = 7.20;
            double keyholdersPrice = 3.60;
            double paintingsPrice = 18.20;
            double surprizesPrice = 22;

            double discount = 0;
            double expensesPercentage = 0.10;

            int totalOrders = loveLetters + roses + keyholders + paintings + surprizes;

            if (totalOrders >= 25)
            {
                discount = 0.35;
            }

            double income = (loveLetters * loveLettersPrice + roses * rosesPrice + keyholders * keyholdersPrice +
                paintings * paintingsPrice + surprizes * surprizesPrice) * (1-discount);
            double profit = income * (1 - expensesPercentage);

            if (profit >= neededMoney)
            {
                Console.WriteLine($"Yes! {(profit-neededMoney):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(neededMoney-profit):f2} lv needed.");
            }
        }
    }
}
