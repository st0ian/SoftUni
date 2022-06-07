using System;

namespace P7_Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int homeVolume = width * length * height;

            int neededVolume = 0;
            bool done = true;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int nextBoxes = int.Parse(input);

                homeVolume -= nextBoxes;

                if (homeVolume <= 0)
                {
                    neededVolume = Math.Abs(homeVolume);
                    done = false;
                    break;
                }
                input = Console.ReadLine();
            }
            
            if (done)
            {
                Console.WriteLine($"{homeVolume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {neededVolume} Cubic meters more.");
            }
        }
    }
}
