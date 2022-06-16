using System;

namespace P7_HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double greenNormative = 1 / 3.4;
            double redNormative = 1 / 4.3;

            double unusedAreaFront = 1.2 * 2;
            double unusedAreaSides = 2 * (1.5 * 1.5);

            double wallsArea = (x * x) * 2 + (x * y) * 2 - unusedAreaFront - unusedAreaSides;
            double roofArea = (x * y) * 2 + (x * h / 2) * 2;

            double greenPaint = wallsArea * greenNormative;
            double redPaint = roofArea * redNormative;

            Console.WriteLine($"{greenPaint:f2}\n{redPaint:f2}");
        }
    }
}
