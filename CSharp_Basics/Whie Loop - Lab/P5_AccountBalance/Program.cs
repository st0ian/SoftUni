using System;

namespace P5_AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                    
            double currentBalance = 0;
            string command;

            while ((command = Console.ReadLine()) != "NoMoreMoney")
            {
                double deposit = double.Parse(command);
                
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {deposit:f2}");
                currentBalance += deposit;                
            }

            Console.WriteLine($"Total: {currentBalance:f2}");
        }
    }
}
