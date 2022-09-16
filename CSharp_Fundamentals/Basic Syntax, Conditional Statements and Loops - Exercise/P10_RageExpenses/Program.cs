using System;

namespace P10_RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displeyPrice = double.Parse(Console.ReadLine());

            int headsets = lostGames / 2;
            int mouses = lostGames / 3;
            int keyboards = lostGames / 6;
            int displeys = lostGames / 12;

            double expenses = headsets * headsetPrice + mouses * mousePrice + keyboards * keyboardPrice + displeys * displeyPrice;

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
