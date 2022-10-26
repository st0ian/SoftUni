using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();
                string comandName = cmdArgs[0];
                int comandValue = int.Parse(cmdArgs[1]);

                if (comandName == "Add")
                {
                    numbers.Add(comandValue);
                }
                else if (comandName == "Remove")
                {
                    if (numbers.Contains(comandValue))
                    {
                        numbers.Remove(comandValue);
                    }
                }
                else if (comandName == "RemoveAt")
                {
                    numbers.RemoveAt(comandValue);
                }
                else if (comandName == "Insert")
                {
                    int insertIndex = int.Parse(cmdArgs[2]);
                    numbers.Insert(insertIndex, comandValue);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
