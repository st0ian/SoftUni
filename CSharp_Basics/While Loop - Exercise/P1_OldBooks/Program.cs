using System;

namespace P1_OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string theBook = Console.ReadLine();

            int counter = 0;
            string input;

            while ((input = Console.ReadLine()) != "No More Books")
            {
                if (input == theBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;
            }

            if (input != theBook)
            {
                Console.WriteLine($"The book you search is not here!\nYou checked {counter} books.");
            }
        }
    }
}
