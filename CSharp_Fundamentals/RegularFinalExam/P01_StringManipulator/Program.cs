using System;

namespace P01_StringManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine(); //   //Thi5 I5 MY 5trING!//

            while (command != "End")
            {
                string[] commandArgs = command.Split(' ');
                string cmdName = commandArgs[0];

                if (cmdName == "Translate")
                {
                    char currentChar = char.Parse(commandArgs[1]);
                    char replacement = char.Parse(commandArgs[2]);

                    if (input.Contains(currentChar))
                    {
                        input = input.Replace(currentChar, replacement);
                    }

                    Console.WriteLine(input);
                }
                else if (cmdName == "Includes")
                {
                    string targetSubstring = commandArgs[1];

                    Console.WriteLine(input.Contains(targetSubstring));                    
                }
                else if (cmdName == "Start")
                {
                    string targetStart = commandArgs[1];
                    Console.WriteLine(input.StartsWith(targetStart));
                    
                }
                else if (cmdName == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (cmdName == "FindIndex")
                {
                    char targetChar = char.Parse(commandArgs[1]);
                    Console.WriteLine(input.LastIndexOf(targetChar));
                }
                else if (cmdName == "Remove")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int count = int.Parse(commandArgs[2]);

                    string modified = input.Remove(startIndex, count);
                    input = modified;
                    Console.WriteLine(input);
                }

                command = Console.ReadLine();
            }
        }
    }
}
