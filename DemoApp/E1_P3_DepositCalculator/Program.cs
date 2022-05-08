using System;

namespace Task3
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double yearlyInterest = double.Parse(Console.ReadLine());

            double interest = deposit * (yearlyInterest / 100);
            double monthlyInterest = interest/12;

            double sum = deposit + monthlyInterest * months;

            Console.WriteLine(sum);
        }
    }
}