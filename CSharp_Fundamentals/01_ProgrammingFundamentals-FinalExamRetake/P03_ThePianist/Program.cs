using System;
using System.Collections.Generic;

namespace P03_ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> favouritesList = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine().Split('|');
                                
                string piece = info[0];
                string composer = info[1];
                string key = info[2];

                if (!favouritesList.ContainsKey(piece))
                {
                    favouritesList[piece] = new List<string>();
                }

                favouritesList[piece].Add(composer);
                favouritesList[piece].Add(key);
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArgs = command.Split('|');
                string commandName = commandArgs[0];
                string piece = commandArgs[1];

                if (commandName == "Add")
                {
                    string composer = commandArgs[2];
                    string key = commandArgs[3];

                    if (!favouritesList.ContainsKey(piece))
                    {
                        favouritesList.Add(piece, new List<string>() { composer, key });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (commandName == "Remove")
                {
                    if (favouritesList.ContainsKey(piece))
                    {
                        favouritesList.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (commandName == "ChangeKey")
                {
                    string newKey = commandArgs[2];

                    if (!favouritesList.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        favouritesList[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in favouritesList)
            {
                string piece = item.Key;
                string composer = item.Value[0];
                string key = item.Value[1];

                Console.WriteLine($"{piece} -> Composer: {composer}, Key: {key}");
            }            
        }
    }
}
