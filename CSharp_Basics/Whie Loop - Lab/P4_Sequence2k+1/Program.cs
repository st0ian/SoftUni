using System;

namespace P4_Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limiter = int.Parse(Console.ReadLine());

            int currentNum = 1;

            while (currentNum <= limiter)
            {
                Console.WriteLine(currentNum);
                currentNum = currentNum * 2 + 1;
            }
        }
    }
}
