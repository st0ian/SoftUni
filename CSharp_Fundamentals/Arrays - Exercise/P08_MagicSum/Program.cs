using System;
using System.Linq;

namespace P08_MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ')
                                       .Select(int.Parse)
                                       .ToArray();
            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length; i++)
            {
                int curFirstNum = input[i];

                for (int pos = i+1; pos < input.Length; pos++)
                {
                    int curSecondNum = input[pos];

                    if (curFirstNum + curSecondNum == magicNumber)
                    {
                        Console.WriteLine(curFirstNum + " " + curSecondNum);
                    }
                }
            }
        }
    }
}
