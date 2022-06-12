using System;

namespace P5_Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int fineFB = 150;
            int fineInstagram = 100;
            int fineReddit = 50;

            int fines = 0;            

            for (int i = 0; i < tabs; i++)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Facebook":
                        fines += fineFB;
                        break;
                    case "Instagram":
                        fines += fineInstagram;
                        break;
                    case "Reddit":
                        fines += fineReddit;
                        break;
                    default:
                        break;
                }
                if (salary - fines <= 0)
                {
                    break;
                }
            }

            int difference = salary - fines;

            if (difference > 0)
            {
                Console.WriteLine(difference);
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
