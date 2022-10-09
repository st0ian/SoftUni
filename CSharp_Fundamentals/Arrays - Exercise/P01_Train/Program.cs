using System;

namespace P01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vagons = int.Parse(Console.ReadLine());

            int[] passangers = new int[vagons];
            int totalPassangers = 0;

            for (int i = 0; i < vagons; i++)
            {
                int nextVagonPassangers = int.Parse(Console.ReadLine());
                passangers[i] = nextVagonPassangers;
                totalPassangers+=passangers[i];
            }

            foreach (int item in passangers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($"{Environment.NewLine}{totalPassangers}");
        }
    }
}
