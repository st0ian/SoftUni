using System;

namespace P4_TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reviewers = int.Parse(Console.ReadLine());

            string command = "";
            double topicsCount = 0;
            double totalScore = 0;

            while (command != "Finish")
            {
                command = Console.ReadLine();
                if (command == "Finish")
                {
                    break;
                }

                string topic = command;
                double topicTotalGrades = 0;
                

                for (int i = 0; i < reviewers; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    topicTotalGrades += grade;
                }

                topicsCount++;
                double topicGrade = topicTotalGrades / reviewers;
                totalScore += topicGrade;

                Console.WriteLine($"{topic} - {topicGrade:f2}.");
            }

            double averageScore = totalScore / topicsCount;
            Console.WriteLine($"Student's final assessment is {averageScore:f2}.");
        }
    }
}
