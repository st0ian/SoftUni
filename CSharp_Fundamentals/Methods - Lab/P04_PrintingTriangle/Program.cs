using System;

namespace P04_PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            printTriangle(input);
        }

        private static void printTriangle(int input)
        {
            for (int row = 0; row <= input; row++)
            {
                printRows(row);
            }

            for (int row = input - 1; row > 0; row--)
            {
                printRows(row);
            }
        }

        static void printRows(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}
