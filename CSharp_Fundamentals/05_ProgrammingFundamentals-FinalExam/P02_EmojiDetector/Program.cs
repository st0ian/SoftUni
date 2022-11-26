using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace P02_EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            BigInteger coolThreshold = CalculateCoolThreshold(inputText);

            string pattern = @"(\:\:|\*\*)(?<emoji>[A-Z][a-z]{2,})(\1)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputText);

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            foreach (Match match in matches)
            {
                string emojiName = match.Groups["emoji"].Value;
                long emojiCoolness = CalculateEmojiCoolness(emojiName);

                if (emojiCoolness > coolThreshold)
                {
                    Console.WriteLine($"{match.Value} ");
                }
            }
            
        }

        private static long CalculateEmojiCoolness(string emojiName)
        {
            long emojiCoolNess = 0;

            foreach (var item in emojiName)
            {
                emojiCoolNess += (int)item;
            }

            return emojiCoolNess;
        }

        static BigInteger CalculateCoolThreshold(string inputText)
        {
            BigInteger coolThreshold = 1;

            foreach (char ch in inputText)
            {
                if (char.IsDigit(ch))
                {
                    int digit = (int)ch - 48;
                    coolThreshold *= digit;
                }
            }

            return coolThreshold;
        }
    }
}
