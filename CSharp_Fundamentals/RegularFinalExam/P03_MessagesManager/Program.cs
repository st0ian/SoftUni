using System;
using System.Collections.Generic;

namespace P03_MessagesManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            Dictionary<string, int> register = new Dictionary<string, int>();

            string command = Console.ReadLine();

            while(command != "Statistics")
            {
                string[] commandArgs = command.Split('='); 
                string commandName = commandArgs[0];

                if (commandName == "Add")
                {
                    string username = commandArgs[1];
                    int receivedMsgs = int.Parse(commandArgs[2]);
                    int sentMsgs = int.Parse(commandArgs[3]);

                    if (!register.ContainsKey(username))
                    {
                        register.Add(username, (receivedMsgs+sentMsgs));
                    }
                }
                else if (commandName == "Message")
                {

                    string sender = commandArgs[1];
                    string receiver = commandArgs[2];

                    if (register.ContainsKey(sender) && register.ContainsKey(receiver))
                    {
                        register[sender]++;
                        register[receiver]++;

                        if (register[sender] >= capacity)
                        {
                            register.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        if (register[receiver] >= capacity)
                        {
                            register.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                    }
                }
                else if (commandName == "Empty")
                {
                    string username = commandArgs[1];

                    if (register.ContainsKey(username))
                    {
                        register.Remove(username);
                    }
                    else if (username == "All")
                    {
                        register.Clear();
                    }
                }

                command = Console.ReadLine();   
            }

            int usersCount = register.Count;
            Console.WriteLine($"Users count: {usersCount}");

            foreach (var kvp in register)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
