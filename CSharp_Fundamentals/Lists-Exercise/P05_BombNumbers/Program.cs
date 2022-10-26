using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNum = bomb[0];
            int bombPower = bomb[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int curNumber = numbers[i];
                
                if (curNumber == bombNum)
                {                    
                    for (int l = 0; l < bombPower; l++)
                    {
                        if (i - 1 - l >= 0)
                        {
                            numbers.RemoveAt(i - 1 - l);
                            numbers.Insert(i-1-l, 0);
                        }
                        if (i + 1 + l < numbers.Count)
                        {
                            numbers.RemoveAt(i + 1 + l);
                            numbers.Insert(i + 1 + l, 0);
                        }
                    }
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(numbers.Sum());

          //
          // https://pastebin.com/kyEmREYZ
        }
    }
}
