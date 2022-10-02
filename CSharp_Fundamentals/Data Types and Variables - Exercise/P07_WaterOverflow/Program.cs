using System;

namespace P07_WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int reservoirMaxVolume = 255;
            int reservoirCurrentVolume = 0;

            for (int i = 0; i < n; i++)
            {
                int nextQuantity = int.Parse(Console.ReadLine());

                bool enoughSpace = (reservoirCurrentVolume + nextQuantity) <= reservoirMaxVolume;

                if (!enoughSpace)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                reservoirCurrentVolume += nextQuantity;
            }

            Console.WriteLine(reservoirCurrentVolume);
        }
    }
}
