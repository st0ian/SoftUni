using System;

namespace P6_Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int fl = floors; fl >= 1; fl--)
            {

                for (int room = 0; room < rooms; room++)
                {
                    if (fl == floors)
                    {
                        Console.Write($"L{fl}{room} ");
                    }
                    else if (fl%2 == 0)
                    {
                        Console.Write($"O{fl}{room} ");
                    }
                    else if (fl%2 != 0)
                    {
                        Console.Write($"A{fl}{room} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
