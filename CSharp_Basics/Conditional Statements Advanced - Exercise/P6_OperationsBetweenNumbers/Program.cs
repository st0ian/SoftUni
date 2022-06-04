using System;

namespace P6_OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char mathOperator = char.Parse(Console.ReadLine());

            if (num2 == 0 && (mathOperator == '/' || mathOperator == '%'))
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
                Environment.Exit(0);
            }

            double result = 0;

            switch (mathOperator)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = (double)num1 / num2;
                    break;
                case '%':
                    result = num1 % num2;
                    break;
            }

            bool isEven = result % 2 == 0;

            string print = $"{num1} {mathOperator} {num2} = {result}";

            if (isEven && mathOperator != '/' && mathOperator != '%')
            {
                print += " - even";
            }
            else if (!isEven && mathOperator != '/' && mathOperator != '%')
            {
                print += " - odd";
            }
            else if (mathOperator == '/')
            {
                print = $"{num1} {mathOperator} {num2} = {result:f2}";
            }

            Console.WriteLine(print);
        }
    }
}
