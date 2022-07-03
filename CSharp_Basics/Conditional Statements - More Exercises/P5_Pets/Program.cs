using System;

namespace P5_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogPerDay = double.Parse(Console.ReadLine());
            double catPerDay = double.Parse(Console.ReadLine());
            double turtlePerDay = double.Parse(Console.ReadLine());

            double dogEats = days * dogPerDay;
            double catEats = days * catPerDay;
            double turtleEats = days * turtlePerDay / 1000;

            double neededFood = dogEats + catEats + turtleEats;
            double difference = Math.Abs(food - neededFood);

            if (food >= neededFood)
            {
                Console.WriteLine($"{Math.Floor(difference)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(difference)} more kilos of food are needed.");
            }
        }
    }
}
