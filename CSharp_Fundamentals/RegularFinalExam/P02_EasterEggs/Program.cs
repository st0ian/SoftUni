using System;
using System.Text.RegularExpressions;

namespace P02_EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"[@#]+(?<color>[a-z]{3,})[@#]+[^a-z0-9]*\/+(?<ammount>\d+)\/+";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string color = match.Groups["color"].Value;
                string amount = match.Groups["ammount"].Value;

                Console.WriteLine($"You found {amount} {color} eggs!");
            }
        }
    }
}
