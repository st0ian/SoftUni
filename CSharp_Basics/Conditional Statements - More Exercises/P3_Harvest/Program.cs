using System;

namespace P3_Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double yeildPerSqM = double.Parse(Console.ReadLine());
            int neededLiters = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalYeild = area * yeildPerSqM;
            double yeildForWine = 0.40 * totalYeild;

            double producedLiters = yeildForWine / 2.5;

            if (producedLiters >= neededLiters)
            {
                double difference = producedLiters - neededLiters;
                double littersPerWorker = Math.Ceiling(difference / workers);

                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(producedLiters)} liters.\n{Math.Ceiling(difference)} liters left -> " +
                    $"{Math.Ceiling(littersPerWorker)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLiters-producedLiters)} liters wine needed.");
            }
        }
    }
}
