using System;

namespace P01_IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int forthNum = int.Parse(Console.ReadLine());

            int firstOperation = firstNum + secondNum;
            decimal secondOperation = firstOperation / thirdNum;
            decimal thirdOperation = secondOperation * forthNum;

            Console.WriteLine(thirdOperation);
        }
    }
}
