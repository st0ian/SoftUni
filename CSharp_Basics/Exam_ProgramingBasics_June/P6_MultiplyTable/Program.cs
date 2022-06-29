using System;

namespace P6_MultiplyTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string input = number.ToString();
            int thirdDigit = int.Parse(input[2].ToString());
            int secondDigit = int.Parse(input[1].ToString());
            int firstDigit = int.Parse(input[0].ToString());

            for (int first = 1; first <= thirdDigit; first++)
            {  
                for (int second = 1; second <= secondDigit; second++)
                {
                    for (int third = 1; third <= firstDigit; third++)
                    {
                        Console.WriteLine($"{first} * {second} * {third} = {first * second * third};");
                    }
                }
            }
        }
    }
}
