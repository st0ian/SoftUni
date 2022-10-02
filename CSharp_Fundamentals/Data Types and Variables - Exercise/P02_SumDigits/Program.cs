using System;

namespace P02_SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sum = 0;
            int sum2 = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += int.Parse(input[i].ToString());
            }

            foreach (var item in input)
            {
                sum2 += int.Parse(item.ToString());
            }

            Console.WriteLine(sum);
            Console.WriteLine(sum2);
        }
    }
}
