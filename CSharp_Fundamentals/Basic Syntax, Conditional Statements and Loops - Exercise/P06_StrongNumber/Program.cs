using System;

namespace P06_StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numCopy = number;
            int sumFactorials = 0;

            while (numCopy>0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;

                int factorial = 1;
                for (int i = 1; i <= lastDigit; i++)
                {
                    factorial *= i;
                }
                sumFactorials += factorial;
            }
            
            if (sumFactorials == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
