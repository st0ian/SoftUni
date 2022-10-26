using System;
using System.Collections.Generic;

namespace P04_ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();


            for (int i = 0; i < n; i++)
            {
                string nextItem = Console.ReadLine();
                products.Add(nextItem);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
