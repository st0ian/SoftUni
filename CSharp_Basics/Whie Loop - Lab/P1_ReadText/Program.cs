using System;

namespace P1_ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string result;

            while ((result = Console.ReadLine()) != "Stop")
            {

                Console.WriteLine(result);
            }
        }
    }
}
