using System;
using System.Collections.Generic;

namespace P02_VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(vowelsCoount(input));
        }

        public static int vowelsCoount(string input)
        {
            int vowelsCount = 0;
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (vowels.Contains(currentChar))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
