using System;

namespace P05_PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int currentIndex = startIndex; currentIndex <= endIndex; currentIndex++)
            {
                char currentChar = (char)currentIndex;
                Console.Write(currentChar + " ");
            }
        }
    }
}
