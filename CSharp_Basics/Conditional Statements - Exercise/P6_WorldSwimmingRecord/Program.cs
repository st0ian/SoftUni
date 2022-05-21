using System;

namespace P6_WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double waterDileyPer15Meters = 12.5;

            int timesOfDiley = (int)distanceMeters/15;
            double lostTime = waterDileyPer15Meters * timesOfDiley;
            double time = distanceMeters*secondsPerMeter + lostTime;

            if (time < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {String.Format("{0:0.00}", time)} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {String.Format("{0:0.00}", time-recordInSeconds)} seconds slower.");
            }
        }
    }
}
