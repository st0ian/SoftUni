using System;
using System.Text.RegularExpressions;

namespace P03_SoftUniBarIncom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^\%\|\$\.]*<(?<product>\w+)>[^\%\|\$\.]*\|(?<quantity>\d+)\|[^\%\|\$\.]*?(?<price>\d+[\.]?\d+)\$";
            Regex regex = new Regex(pattern);
            double totalIncome = 0;

            string input = Console.ReadLine();
            string test = string.Empty;

            while (input != "end of shift")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double currentIncome = quantity * price;
                    totalIncome += currentIncome;

                    Console.WriteLine($"{customer}: {product} - {currentIncome:f2}");
                }                

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
