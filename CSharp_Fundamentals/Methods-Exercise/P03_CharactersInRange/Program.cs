using System;
using System.Collections.Generic;

namespace P03_CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());

            if (firstCh > secondCh)
            {
                var temp = secondCh;
                secondCh = firstCh;
                firstCh = temp;
            }

            PrintAllCharsBetweenTwo(firstCh, secondCh);
        }

        private static void PrintAllCharsBetweenTwo(char firstCh, char secondCh)
        {
            List <char> result = new List<char>();

            for (int i = firstCh+1 ; i < secondCh; i++)
            {
                char currentCh = (char)i;
                result.Add(currentCh);
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
