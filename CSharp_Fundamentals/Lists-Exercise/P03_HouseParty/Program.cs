using System;
using System.Collections.Generic;

namespace P03_HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());
            List <string> guestsList= new List<string>();

            for (int i = 0; i < inputs; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];

                if (command[2] == "going!")
                {
                    if (!guestsList.Contains(name))
                    {
                        guestsList.Add(name);
                    }
                    else if (guestsList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else
                {
                    if (guestsList.Contains(name))
                    {
                        guestsList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }                
            }

            Console.WriteLine(string.Join(Environment.NewLine, guestsList));
        }
    }
}
