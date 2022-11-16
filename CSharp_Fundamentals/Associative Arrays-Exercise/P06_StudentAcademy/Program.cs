using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List <double>> studentsBook = new Dictionary<string, List<double>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsBook.ContainsKey(name))
                {
                    studentsBook.Add(name, new List<double>());
                }

                studentsBook[name].Add(grade);      
            }

            foreach (var kvp in studentsBook)
            {
                if (kvp.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
                }                
            }
        }
    }
}
