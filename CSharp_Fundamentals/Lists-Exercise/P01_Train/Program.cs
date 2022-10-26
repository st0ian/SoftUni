using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagones = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();


                if (cmdArgs.Length == 2)
                {
                    int passangers = int.Parse(cmdArgs[1]);
                    wagones.Add(passangers);
                }
                else if (cmdArgs.Length == 1)
                {
                    int passangers = int.Parse(cmdArgs[0]);

                    for (int i = 0; i < wagones.Count; i++)
                    {
                        int currentPassangers = wagones[i];

                        if ((passangers + currentPassangers) <= capacity)
                        {
                            wagones[i] += passangers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagones));
        }
    }
}
