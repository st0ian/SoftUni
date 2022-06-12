using System;

namespace P2_EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int start = first; start <= second; start++)
            {
                string curNum = start.ToString();
                int sumOdd = 0;
                int sumEven = 0;

                for (int position = 0; position < curNum.Length; position++)
                {
                    int digit = int.Parse(curNum[position].ToString());
                    if (position%2 == 0)
                    {
                        sumEven += digit;
                    }
                    else
                    {
                        sumOdd += digit;
                    }
                }
                if (sumEven == sumOdd)
                {
                    Console.Write($"{curNum} ");
                }
            }
        }
    }
}
