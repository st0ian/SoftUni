using System;

namespace P5_TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine()) * 100;
            double width = double.Parse(Console.ReadLine()) * 100;

            double hallwayWidth = 100;
            int unusableSpaceInDesks = 1 + 2;

            double usableWidth = width - hallwayWidth;
            int deskWidth = 40 + 80;
            int deskLength = 70;

            int desksInRow = (int)usableWidth / deskLength;
            int rows = (int)length / deskWidth;

            int desks = desksInRow * rows - unusableSpaceInDesks;

            Console.WriteLine($"{desks}");
        }
    }
}
