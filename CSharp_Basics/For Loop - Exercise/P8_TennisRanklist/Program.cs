using System;

namespace P8_TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int pointsW = 2000;
            int pointsF = 1200;
            int pointsSF = 720;

            int wins = 0;
            int totalPoints = startingPoints;

            for (int i = 0; i < tournaments; i++)
            {
                string stage = Console.ReadLine();

                switch (stage)
                {
                    case "W":
                        wins++;
                        totalPoints += pointsW;
                        break;
                    case "F":
                        totalPoints += pointsF;
                        break;
                    case "SF":
                        totalPoints += pointsSF;
                        break;
                    default:
                        break;
                }
            }

            double averagePoints = (totalPoints - startingPoints) / tournaments;
            double winRate = ((double)wins / tournaments) *100;

            Console.WriteLine($"Final points: {totalPoints}\nAverage points: {averagePoints}\n{winRate:f2}%");
        }
    }
}
