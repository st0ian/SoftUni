using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool isChanged = false;
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();
                string comandName = cmdArgs[0];

                if (comandName == "Add")
                {
                    int comandValue = int.Parse(cmdArgs[1]);
                    numbers.Add(comandValue);

                    isChanged = true;
                }
                else if (comandName == "Remove")
                {
                    int comandValue = int.Parse(cmdArgs[1]);

                    if (numbers.Contains(comandValue))
                    {
                        numbers.Remove(comandValue);
                    }
                    isChanged = true;
                }
                else if (comandName == "RemoveAt")
                {
                    int comandValue = int.Parse(cmdArgs[1]);
                    numbers.RemoveAt(comandValue);

                    isChanged = true;
                }
                else if (comandName == "Insert")
                {
                    int comandValue = int.Parse(cmdArgs[1]);
                    int insertIndex = int.Parse(cmdArgs[2]);
                    numbers.Insert(insertIndex, comandValue);

                    isChanged = true;
                }
                else if (comandName == "Contains")
                {
                    int comandValue = int.Parse(cmdArgs[1]);

                    if (numbers.Contains(comandValue))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (comandName == "PrintEven")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);

                    Console.WriteLine(String.Join(" ", evenNumbers));
                }
                else if (comandName == "PrintOdd")
                {
                    List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);

                    Console.WriteLine(String.Join(" ", oddNumbers));
                }
                else if (comandName == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (comandName == "Filter")
                {
                    string condition = cmdArgs[1];
                    int number = int.Parse(cmdArgs[2]);

                    switch (condition)
                    {
                        case ">":
                            Console.WriteLine(string.Join(" ", numbers.FindAll(x => x > number)));
                            break;
                        case "<":
                            Console.WriteLine(string.Join(" ", numbers.FindAll(x => x < number)));
                            break;
                        case ">=":
                            Console.WriteLine(string.Join(" ", numbers.FindAll(x => x >= number)));
                            break;
                        case "<=":
                            Console.WriteLine(string.Join(" ", numbers.FindAll(x => x <= number)));
                            break;
                        default:
                            Console.WriteLine("Invalid condition");
                            break;
                    }
                }

                command = Console.ReadLine();
            }

            if (isChanged)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
