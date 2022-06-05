using System;

namespace P4_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            int neededSteps = 0;
            int goal = 10000;
            int stepsOver = 0;
            bool goalReached = false;

            while (!goalReached)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int stepsHome = int.Parse(Console.ReadLine());
                    if (totalSteps + stepsHome >= goal)
                    {
                        goalReached = true;
                        stepsOver = totalSteps + stepsHome - goal;
                    }
                    else
                    {
                        neededSteps = goal - totalSteps - stepsHome;
                    }
                    break;
                }

                int addSteps = int.Parse(input);

                totalSteps += addSteps;
                stepsOver = totalSteps - goal;
                goalReached = totalSteps >= goal;
            }

            if (goalReached)
            {
                Console.WriteLine($"Goal reached! Good job!\n{stepsOver} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{neededSteps} more steps to reach goal.");
            }
        }
    }
}
