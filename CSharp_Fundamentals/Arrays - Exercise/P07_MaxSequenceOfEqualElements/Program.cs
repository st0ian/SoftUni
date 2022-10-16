using System;
using System.Linq;

namespace P07_MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ')
                                            .Select(int.Parse)
                                            .ToArray();

            int longestSequence = 0;
            int currentLongest = 0;
            int digit = default;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i + 1] == input[i])
                {
                    currentLongest++;
                    if (currentLongest > longestSequence)
                    {
                        longestSequence = currentLongest;
                        digit = input[i];
                    }
                }

                else if (input[i + 1] != input[i])
                {
                    if (currentLongest > longestSequence)
                    {
                        longestSequence = currentLongest;
                        digit = input[i];
                    }
                    currentLongest = 0;
                }
            }

            PrintSequenceOfDigits(longestSequence, digit);
        }

        private static void PrintSequenceOfDigits(int longestSequence, int digit)
        {
            for (int i = 0; i <= longestSequence; i++)
            {
                Console.Write(digit + " ");
            }
        }
    }
}
