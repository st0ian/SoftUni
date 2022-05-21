using System;

namespace P8_LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double launchTime = breakTime / 8.0;
            double relaxTime = breakTime / 4.0;
            double movieTime = breakTime - launchTime - relaxTime;

            if (movieTime >= episodeTime)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(movieTime-episodeTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(episodeTime-movieTime)} more minutes.");
            }
        }
    }
}
