using System;

namespace P3_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int days = 0;
            string action;
            int limiter = 0;

            while (true)
            {
                days++;
                action = Console.ReadLine();
                
                double ammount = double.Parse(Console.ReadLine());
                if (action == "save")
                {
                    currentMoney += ammount;
                    limiter = 0;
                    if (currentMoney >= neededMoney)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        break;
                    }
                }
                else
                {
                    currentMoney -= ammount;
                    if (currentMoney < 0)
                    {
                        currentMoney = 0;
                    }
                    limiter++;
                    if (limiter == 5)
                    {
                        Console.WriteLine($"You can't save the money.\n{days}");
                        break;
                    }
                }
            }
        }
    }
}
