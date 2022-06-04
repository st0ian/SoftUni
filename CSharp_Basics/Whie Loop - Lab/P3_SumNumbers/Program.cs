using System;

namespace P3_SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targeredSum = int.Parse(Console.ReadLine());

            int sum = 0;
            while (sum < targeredSum)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
            }
            Console.WriteLine(sum); 
        }
    }
}
