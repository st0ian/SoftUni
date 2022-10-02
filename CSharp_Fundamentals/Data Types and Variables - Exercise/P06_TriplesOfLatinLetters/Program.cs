using System;

namespace P06_TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int startIndex = 97;

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        char first = (char)(startIndex+i);
                        char second = (char)(startIndex+k);
                        char third = (char)(startIndex+j);

                        Console.Write ($"{first}{second}{third}{Environment.NewLine}");
                    }                    
                }
            }
        }
    }
}
