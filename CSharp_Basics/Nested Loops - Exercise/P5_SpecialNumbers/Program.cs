using System;

namespace P5_SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1111; num <= 9999; num++)
            {

                string nextNum = num.ToString();
                bool isMagic = true;

                for (int position = 0; position < nextNum.Length; position++)
                {
                    int digit = int.Parse(nextNum[position].ToString());

                    if (digit == 0)
                    {
                        isMagic = false;
                        continue;
                    }

                    if (n%digit != 0)
                    {
                        isMagic = false;
                    }
                }

                if (isMagic)
                {
                    Console.Write($"{nextNum} ");
                }
            }
        }
    }
}
