using System;
using System.Text;

namespace P01_ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder activationKey = new StringBuilder(Console.ReadLine());

            string input = Console.ReadLine();

            while(input != "Generate")
            {
                string[] cmdArg = input.Split(">>>");
                string command = cmdArg[0];

                if (command == "Contains")
                {
                    string subString = cmdArg[1];
                    if (activationKey.ToString().Contains(subString))
                    {
                        Console.WriteLine($"{activationKey} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                    
                }
                else if (command == "Flip")
                {
                    string flipType = cmdArg[1];
                    int startIndex = int.Parse(cmdArg[2]);
                    int endIndex = int.Parse(cmdArg[3]);
                    string subString = activationKey.ToString().Substring(startIndex, endIndex - startIndex);

                    if (flipType == "Upper")
                    {
                        subString = subString.ToUpper();
                    }
                    else if (flipType == "Lower")
                    {
                        subString = subString.ToLower();
                    }

                    activationKey.Remove(startIndex, endIndex - startIndex);
                    activationKey.Insert(startIndex, subString);

                    Console.WriteLine(activationKey);
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);


                    activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
