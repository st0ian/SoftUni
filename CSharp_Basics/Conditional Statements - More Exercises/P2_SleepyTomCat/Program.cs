using System;

namespace P2_SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int neededSleepMinutes = 30000;

            int playTime = daysOff * 127 + (365 - daysOff) * 63;

            int hoursDiff = Math.Abs((neededSleepMinutes - playTime) / 60);
            int minutesDiff = Math.Abs((neededSleepMinutes - playTime) % 60);
            
            if (neededSleepMinutes >= playTime)
            {
                Console.WriteLine($"Tom sleeps well\n{hoursDiff} hours and {minutesDiff} minutes less for play");
            }
            else
            {
                Console.WriteLine($"Tom will run away\n{hoursDiff} hours and {minutesDiff} minutes more for play");
            }
        }
    }
}
