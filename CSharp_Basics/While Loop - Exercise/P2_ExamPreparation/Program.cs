using System;

namespace P2_ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGradesLimit = int.Parse(Console.ReadLine());

            string task;
            int badGrades = 0;
            double score = 0;
            int counter = 0;
            string lastTask = string.Empty;

            while ((task = Console.ReadLine()) != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                counter++;
                if (grade <= 4)
                {
                    badGrades++;
                    if (badGrades == badGradesLimit)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        break;
                    }                                       
                }
                score += grade;
                lastTask = task;
            }
            if (badGrades < badGradesLimit)
            {
                double averageScore = score / counter;
                Console.WriteLine($"Average score: {averageScore:f2}\nNumber of problems: {counter}\nLast problem: {lastTask}");
            }
        }
    }
}
