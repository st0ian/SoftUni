using System;

internal class Program
{
    static void Main(string[] args)
    {
        int dogFood = int.Parse(Console.ReadLine());
        int catFood = int.Parse(Console.ReadLine());

        const double priceDogFood = 2.5;
        const double priceCatFood = 4;

        double sum = dogFood * priceDogFood + catFood * priceCatFood;

        Console.WriteLine($"{sum} lv.");
    }
}
