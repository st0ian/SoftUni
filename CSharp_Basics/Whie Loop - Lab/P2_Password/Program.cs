using System;

namespace P2_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string enteredPassword;
            while ((enteredPassword = Console.ReadLine()) != password)
            {             
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
