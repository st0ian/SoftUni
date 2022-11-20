using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rowParticipants = Console.ReadLine().Split(", ");
            Dictionary<string, int> participants = new Dictionary<string, int>();

            foreach (string participant in rowParticipants)
            {
                participants[participant] = 0;
            }

            string patternName = $@"[A-Za-z]+";
            string patternDistance = $@"\d";
            Regex regexName = new Regex(patternName);
            Regex regexDistance = new Regex(patternDistance);

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection matchName = regexName.Matches(input);
                MatchCollection matchDistance = regexDistance.Matches(input);

                string currentName = string.Empty;

                foreach (Match letter in matchName)
                {
                    currentName += letter;
                }

                if (!participants.ContainsKey(currentName))
                {
                    input = Console.ReadLine();
                    continue;
                }

                int distance = 0;
                foreach (Match digit in matchDistance)
                {
                    distance += int.Parse(digit.ToString());
                }
                participants[currentName] += distance;

                input = Console.ReadLine();
            }

            var finalStandings = participants.OrderByDescending(x => x.Value);

            Console.WriteLine($"1st place: {finalStandings.ElementAt(0).Key}");
            Console.WriteLine($"2nd place: {finalStandings.ElementAt(1).Key}");
            Console.WriteLine($"3rd place: {finalStandings.ElementAt(2).Key}");
        }
    }
}
