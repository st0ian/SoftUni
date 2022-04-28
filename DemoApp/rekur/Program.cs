using System;

internal class Program
{
    static void Main(string[] args)
    {
        double area = 0;

            string shape = Console.ReadLine();
            switch (shape)
            {
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    area = a * a;
                    break;
                case "rectangle":
                    a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    area = a * b;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    break;
                case "triangle":
                    a = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    area = a * h / 2;
                    break;
                default:
                    Console.WriteLine("Wrong Input! Choose between: square, rectangle, circle or triangle");
                    Main(args);
                    break;
                    }

        Console.WriteLine(area);
    }
}
