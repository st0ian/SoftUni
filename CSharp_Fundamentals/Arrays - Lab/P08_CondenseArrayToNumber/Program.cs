using System;
using System.Linq;

namespace P08_CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = 0; j < input.Length - i -1 ; j++)
                {
                    input[j] = input[j] + input[j+1] ;
                }
            }

            Console.WriteLine(input[0]);
        }
    }
}
