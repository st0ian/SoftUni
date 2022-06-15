using System;

namespace P6_Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double startPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double totalPoints = startPoints;
            double nominationPoints = 1250.5;

            for (int i = 0; i < n; i++)
            {
                string reviewer = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                double pointsName = reviewer.Length;
                totalPoints += (points * pointsName) / 2;

                if (totalPoints >= nominationPoints)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints:f1}!");
                    return;
                }
            }

            double neededPoints = nominationPoints - totalPoints;
            Console.WriteLine($"Sorry, {actor} you need {neededPoints:f1} more!");
        }
    }
}
