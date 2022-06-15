using System;

namespace P3_Sum_PrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string command = "";
            int sumPrime = 0;
            int sumeNonPrime = 0;

            while (command != "stop")
            {
                command = Console.ReadLine();
                bool isPrime = true;

                if (command == "stop")
                {
                    break;
                }

                int nextNumber = int.Parse(command);
                if (nextNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int i = 2; i < nextNumber; i++)
                {
                    if (nextNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sumPrime += nextNumber;
                }
                else
                {
                    sumeNonPrime += nextNumber;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}\nSum of all non prime numbers is: {sumeNonPrime}");
        }
    }
}
