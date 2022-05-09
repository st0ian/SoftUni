using System;

internal class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int projects = int.Parse(Console.ReadLine());

        const int hoursPerProject = 3;
        int totalHours = projects * hoursPerProject;

        Console.WriteLine($"The architect {name } will need {totalHours} hours to complete {projects} project/s.");
    }
}
