using System;

internal class Program
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        int after15min = 15;

        if (minutes + after15min >60)
        {
            hours +=1;
            minutes = minutes + after15min - 60;
        }
        else if (minutes + after15min <60)
        {
            minutes = minutes + after15min;
        }
        else
        {
            hours += 1;
            minutes = 0;
        }

        if (hours >= 24 && minutes < 10)
        {
            Console.WriteLine($"{hours - 24}:0{minutes}");
        }            
        else if (hours >=24 && minutes >= 10)
        {
            Console.WriteLine($"{hours - 24}:{minutes}");
        }
        else if (hours < 24 && minutes < 10)
        {
            Console.WriteLine($"{hours}:0{minutes}");
        }
        else
        {
            Console.WriteLine($"{hours}:{minutes}");
        }
        Console.ReadLine();

    }
}
