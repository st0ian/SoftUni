using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01_Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<string> furnitureList = new List<string>();
            double totalSpent = 0;
            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();

            while(input != "Purchase")
            {                
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    
                    furnitureList.Add(furnitureName);
                    totalSpent += quantity * price;
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");

            foreach (var furniture in furnitureList)
            {
                Console.WriteLine(furniture);
            }
                Console.WriteLine($"Total money spend: {totalSpent:f2}");
        }
    }
}
