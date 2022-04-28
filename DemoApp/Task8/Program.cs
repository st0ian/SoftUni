using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());

            double snickers = yearTax * 0.6;
            double kit = snickers * 0.8;
            double ball = kit / 4;
            double accesories = ball / 5;

            double totalSum = yearTax + snickers + kit + ball + accesories;  
            
            Console.WriteLine(totalSum);           
        }
    }
}