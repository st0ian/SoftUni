using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();
                string commandName = cmdArgs[0];
                int element = int.Parse(cmdArgs[1]);

                if(commandName == "Delete")
                {
                    numbers.RemoveAll(n => n == element);
                }
                else if (commandName == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);
                    numbers.Insert(index, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
