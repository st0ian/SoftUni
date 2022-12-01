using System;
using System.Text.RegularExpressions;

namespace P02_AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int caloriesPerDay = 2000;
            string foodInfoRaw = Console.ReadLine();

            string pattern = @"(#|\|)(?<name>[A-Za-z\s]+)\1(?<date>[\d]{2}\/[\d]{2}\/[\d]{2})\1(?<calories>[\d]{1,5})\1";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(foodInfoRaw);

            int totalCalories = 0;
            foreach (Match match in matches)
            {
                int calories = int.Parse(match.Groups["calories"].Value);

                totalCalories += calories;
            }

            int daysToLast = totalCalories / caloriesPerDay;
            Console.WriteLine($"You have food to last you for: {daysToLast!} days!");

            foreach (Match match in matches)
            {
                string foodName = match.Groups["name"].Value;
                string expirationDate = match.Groups["date"].Value;
                string calories = match.Groups["calories"].Value;

                Console.WriteLine($"Item: {foodName}, Best before: {expirationDate}, Nutrition: {calories}");
            }
        }
    }
}
