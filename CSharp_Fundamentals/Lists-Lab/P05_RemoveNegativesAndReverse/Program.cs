using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://pastebin.com/L3pp3b7V?fbclid=IwAR07QsgXj7XvMtrxay1wmt9OuKYWoqrPKa3qZr-0vofB3kJ_4vUlViXwI5U

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

           /* for (int i = 0; i < input.Count; i++)
            {
                if (input[i] < 0)
                {
                    input.RemoveAt(i);
                    i = -1;
                }
            }*/

            input.RemoveAll(x => x < 0);

            if (input.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                input.Reverse();

                Console.WriteLine(String.Join(" ", input));
            }
        }
    }
}
