using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").Where(x => x.Length is >= 3 and <= 16).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                string currentName = input[i];

                for (int ch = 0; ch < currentName.Length; ch++)
                {
                    char currentChar = currentName[ch];

                    if ((int)currentChar is >= 48 and <= 57 || currentChar == 45 || currentChar == 95 || (int)currentChar is >= 65 and <= 90 || (int)currentChar is >= 97 and <= 122)
                    {
                        continue;
                    }

                    input.Remove(currentName);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
