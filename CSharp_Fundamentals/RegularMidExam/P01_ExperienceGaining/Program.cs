using System;

namespace P01_ExperienceGaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededExp = double.Parse(Console.ReadLine());
            int possibleBattles = int.Parse(Console.ReadLine());

            double totalExp = 0;
            int playedBattles = 0;

            for (int i = 1; i <= possibleBattles; i++)
            {
                string nextInput = Console.ReadLine();
                double currentExp;
                double.TryParse(nextInput, out currentExp);

                double modifier = 0;
                                
                if (totalExp >= neededExp)
                {                    
                    break;
                }

                if (i % 3 == 0)
                {
                    modifier = 0.15;
                }
                else if (i % 5 == 0)
                {
                    modifier = -0.10;
                }
                else if (i % 15 == 0)
                {
                    modifier = 0.05;
                }

                totalExp += currentExp * (1 + modifier);
                playedBattles++;
            }

            if (totalExp >= neededExp)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {playedBattles} battles.");
            }
            else
            {
                double neededExperience = neededExp - totalExp;
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience:f2} more needed.");
            }
        }
    }
}
