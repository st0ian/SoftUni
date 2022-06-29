using System;

namespace P1_PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int flowP1 = int.Parse(Console.ReadLine());
            int flowP2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double volumeP1 = flowP1 * hours;
            double volumeP2 = flowP2 * hours;
            double volume =  volumeP1 + volumeP2;

            double p1Percentage = volumeP1 / volume * 100;
            double p2Percentage = volumeP2 / volume * 100;
            double filledPercentage = volume / poolVolume * 100;

            if (poolVolume >= volume)
            {
                Console.WriteLine($"The pool is {filledPercentage:f2}% full. Pipe 1: {p1Percentage:f2}%. Pipe 2: {p2Percentage:f2}%.");
            }
            else
            {
                double extraLitters = volume - poolVolume;
                Console.WriteLine($"For {hours} hours the pool overflows with {extraLitters:f2} liters.");
            }
        }
    }
}
