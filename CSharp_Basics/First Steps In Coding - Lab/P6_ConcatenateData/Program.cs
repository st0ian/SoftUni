﻿using System;

internal class Program
{
    static void Main(string[] args)
    {
        string firstName = Console.ReadLine();
        string lastNAme = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string town = Console.ReadLine();

        Console.WriteLine($"You are {firstName} {lastNAme}, a {age}-years old person from {town}.");
    }
}
