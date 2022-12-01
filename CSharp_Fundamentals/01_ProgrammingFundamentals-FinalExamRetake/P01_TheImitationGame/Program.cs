using System;
using System.Text;

namespace P01_TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String message = Console.ReadLine();

            string command = Console.ReadLine();
            StringBuilder sb = new StringBuilder(message);

            while (command != "Decode")
            {
                string[] cmdArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string cmdName = cmdArgs[0];

                if (cmdName == "Move")                     
                {
                    int count = int.Parse(cmdArgs[1]);
                    string movedPart = sb.ToString().Substring(0, count);

                    sb.Remove(0, count).Append(movedPart);
                }
                else if (cmdName == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];

                    sb.Insert(index, value); 
                }
                else if (cmdName == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];

                    sb.Replace(substring, replacement);
                }

                command = Console.ReadLine();
            }

            string decrypedMsg = sb.ToString();
            Console.WriteLine($"The decrypted message is: {decrypedMsg}");
        }
    }
}
