using System;

internal class Program
{
    static void Main(string[] args)
    {
        string input =Console.ReadLine();

        const string key = "s3cr3t!P@ssw0rd";

        if (input == key)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}
