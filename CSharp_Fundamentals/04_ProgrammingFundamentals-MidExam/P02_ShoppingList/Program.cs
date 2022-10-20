using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                    .Split('!')
                    .ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] cmdAruments = command.Split(' ').ToArray();
                string commandName = cmdAruments[0];
                string commandItem = cmdAruments[1];


                if (commandName == "Urgent")
                {
                    if (!shoppingList.Contains(commandItem))
                    {
                        shoppingList.Insert(0, commandItem);
                    }
                }
                else if (commandName == "Unnecessary")
                {
                    if (shoppingList.Contains(commandItem))
                    {
                        shoppingList.Remove(commandItem);
                    }
                }
                else if (commandName == "Correct")
                {
                    string commandOldItem = cmdAruments[1];
                    string commandNewItem = cmdAruments[2];

                    if (shoppingList.Contains(commandOldItem))
                    {
                        int index = shoppingList.IndexOf(commandOldItem);
                        shoppingList.RemoveAt(index);
                        shoppingList.Insert(index, commandNewItem);
                    }

                }
                else if (commandName == "Rearrange")
                {
                    if (shoppingList.Contains(commandItem))
                    {
                        shoppingList.Remove(commandItem);
                        shoppingList.Add(commandItem);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
