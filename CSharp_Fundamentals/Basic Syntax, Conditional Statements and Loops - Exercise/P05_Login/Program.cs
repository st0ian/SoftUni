using System;

namespace P05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currentCh = username[i];
                password += currentCh;
            }

            string enteredPassword;
            int attempts = 1;

            while ((enteredPassword = Console.ReadLine()) != password)
            {
                if (attempts >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                attempts++;
            }

            Console.WriteLine($"User { username} logged in.");
        }
    }
}
