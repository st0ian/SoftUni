using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < firstDeck.Count; i++)
            {
                if (firstDeck.Count == 0 || secondDeck.Count == 0)
                {
                    break;
                }

                if (firstDeck[i] > secondDeck[i])
                {
                    firstDeck.Add(secondDeck[i]);
                    firstDeck.Add(firstDeck[i]);
                    firstDeck.RemoveAt(i);
                    secondDeck.RemoveAt(i);
                }
                else if (firstDeck[i] < secondDeck[i])
                {
                    secondDeck.Add(firstDeck[i]);
                    secondDeck.Add(secondDeck[i]);
                    firstDeck.RemoveAt(i);
                    secondDeck.RemoveAt(i);
                }
                else if (firstDeck[i] == secondDeck[i])
                {
                    firstDeck.RemoveAt(i);
                    secondDeck.RemoveAt(i);                    
                }
                i--;
            }

            if (firstDeck.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
        }
    }
}
