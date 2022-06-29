using System;

namespace March9_P2_FootballResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wins = 0;
            int draws = 0;
            int losses = 0;

            for (int i = 0; i < 3; i++)
            {
                string result = Console.ReadLine();

                int homeGoals = int.Parse(result[0].ToString());
                int awayGoals = int.Parse(result[2].ToString());

                if (homeGoals > awayGoals)
                {
                    wins++;
                }
                else if (homeGoals == awayGoals)
                {
                    draws++;
                }
                else
                {
                    losses++;
                }
            }

            Console.WriteLine($"Team won {wins} games.\nTeam lost {losses} games.\nDrawn games: {draws}");
        }
    }
}
