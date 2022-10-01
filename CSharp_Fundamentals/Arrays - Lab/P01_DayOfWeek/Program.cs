﻿using System;

namespace P01_DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int input = int.Parse(Console.ReadLine());

            if (input < 1 || input > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[input - 1]);
            }
        }
    }
}
