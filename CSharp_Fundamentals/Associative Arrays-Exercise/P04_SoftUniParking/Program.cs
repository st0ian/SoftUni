using System;
using System.Collections.Generic;

namespace P04_SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var register = new Dictionary<string, string>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string name = input[1];
                
                if (command == "register")
                {
                    string plateN = input[2];

                    if (register.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateN}");
                        continue;
                    }

                    register.Add(name, plateN);
                    Console.WriteLine($"{name} registered {plateN} successfully");
                }

                else if (command == "unregister")
                {
                    if (!register.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                        continue;
                    }

                    register.Remove(name);
                    Console.WriteLine($"{name} unregistered successfully");
                }
            }

            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
