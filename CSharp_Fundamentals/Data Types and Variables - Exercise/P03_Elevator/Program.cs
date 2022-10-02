using System;

namespace P03_Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int runs = people / capacity;

            if ( people % capacity != 0)
            {
                runs += 1;
            }

            Console.WriteLine(runs);
        }
    }
}
