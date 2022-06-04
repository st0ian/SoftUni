using System;

namespace P8_Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int currentClass = 1;
            double totalGrade = 0;  
            int repeatCounter = 0;

            while (currentClass <= 12)
            {
                double currentClassGrade = double.Parse(Console.ReadLine());
                totalGrade += currentClassGrade;

                if (currentClassGrade < 4)
                {
                    repeatCounter++;
                    if (repeatCounter > 1)
                    {
                        break;
                    }
                    continue;
                }
                
                currentClass++;
            }
            
            if (repeatCounter > 1)
            {
                Console.WriteLine($"{name} has been excluded at {currentClass} grade");
            }
            else
            {
                double averageGrada = totalGrade / (currentClass - 1 + repeatCounter);
                Console.WriteLine($"{name} graduated. Average grade: {averageGrada:f2}");
            }
        }
    }
}
