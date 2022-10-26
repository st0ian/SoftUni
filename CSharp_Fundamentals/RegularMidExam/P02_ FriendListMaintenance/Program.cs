using System;
using System.Collections.Generic;
using System.Linq;

namespace P02__FriendListMaintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friendsList = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();
            int blacklisted = 0;
            int lost = 0;

            while (command != "Report")
            {
                string[] cmdArgs = command.Split(" ");
                string commandName = cmdArgs[0];

                if (commandName == "Blacklist")
                {
                    string name = cmdArgs[1];

                    if (friendsList.Contains(name))
                    {                        
                        var index = friendsList.FindIndex(x => x == name);

                        friendsList.Remove(name);
                        friendsList.Insert(index, "Blacklisted");

                        blacklisted++;

                        Console.WriteLine($"{name} was blacklisted.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (commandName == "Error")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (index >= 0 && index < friendsList.Count && friendsList[index] != "Lost")
                    {
                        if (friendsList[index] != "Blacklisted")
                        {
                            string name = friendsList[index];

                            friendsList.RemoveAt(index);
                            friendsList.Insert(index, "Lost");

                            lost++;

                            Console.WriteLine($"{name} was lost due to an error.");
                        }
                    }
                }
                else if (commandName == "Change")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newName = cmdArgs[2];

                    if (index >= 0 && index < friendsList.Count)
                    {
                        string currentName = friendsList[index];
                        friendsList.RemoveAt(index);
                        friendsList.Insert(index, newName);

                        Console.WriteLine($"{currentName} changed his username to {newName}.");
                    }
                }

                command = Console.ReadLine();   
            }

            Console.WriteLine($"Blacklisted names: {blacklisted}");
            Console.WriteLine($"Lost names: {lost}");
            Console.WriteLine(string.Join(" ", friendsList));
        }
    }
}
