using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] cmdArgs = command.Split();
                string commandName = cmdArgs[0];
                
                if (commandName == "Add")
                {
                    int value = int.Parse(cmdArgs[1]);
                    integers.Add(value);
                }
                else if (commandName == "Insert")
                {
                    int value = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (index < 0 || index >= integers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        integers.Insert(index, value);
                    }                    
                }
                else if (commandName == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (index < 0 || index >= integers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        integers.RemoveAt(index);
                    }                    
                }
                else if (commandName == "Shift")
                {
                    string direction = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);

                    if (direction == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int curFirst = integers[0];
                            integers.Add(curFirst);
                            integers.RemoveAt(0);
                        }
                    }
                    else if(direction == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int curLast = integers[integers.Count-1];
                            integers.Insert(0, curLast);
                            integers.RemoveAt(integers.Count - 1);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
