using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_MessagesManager_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            Dictionary<string, int[]> register = new Dictionary<string, int[]>();

            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] commandArgs = command.Split('=');
                string commandName = commandArgs[0];

                if (commandName == "Add")
                {
                    string username = commandArgs[1];
                    int sentMsgs = int.Parse(commandArgs[2]);
                    int receivedMsgs = int.Parse(commandArgs[3]);

                    if (!register.ContainsKey(username))
                    {
                        // Array will store Sent Messages on position [0] and Received Messages on position [1]
                        register.Add(username, new int[] { sentMsgs, receivedMsgs });
                    }
                }
                else if (commandName == "Message")
                {

                    string sender = commandArgs[1];
                    string receiver = commandArgs[2];

                    if (register.ContainsKey(sender) && register.ContainsKey(receiver))
                    {
                        register[sender][0]++;
                        register[receiver][1]++;

                        if (register[sender].Sum() >= capacity)
                        {
                            register.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        if (register[receiver].Sum() >= capacity)
                        {
                            register.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                    }
                }
                else if (commandName == "Empty")
                {
                    string username = commandArgs[1];

                    EmptyCommand(register, username);                    
                }

                command = Console.ReadLine();
            }

            PrintResult(register);            
        }

        private static void EmptyCommand(Dictionary<string, int[]> register, string username)
        {
            if(register.ContainsKey(username))
                    {
                register.Remove(username);
            }
                    else if (username == "All")
            {
                register.Clear();
            }
        }

        private static void PrintResult(Dictionary<string, int[]> register)
        {
            int usersCount = register.Count;
            Console.WriteLine($"Users count: {usersCount}");

            foreach (var kvp in register)
            {
                string username = kvp.Key;
                int messagesCount = kvp.Value.Sum();

                Console.WriteLine($"{username} - {messagesCount}");
            }
        }
    }
}
