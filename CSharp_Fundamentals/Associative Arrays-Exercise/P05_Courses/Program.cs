using System;
using System.Collections.Generic;

namespace P05_Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> register = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArgs = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = inputArgs[0];
                string student = inputArgs[1];

                if (!register.ContainsKey(course))
                {
                    register.Add(course, new List<string>());
                }

                register[course].Add(student);

                input = Console.ReadLine();
            }

            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
