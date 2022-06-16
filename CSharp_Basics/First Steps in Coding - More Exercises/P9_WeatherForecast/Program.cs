using System;

namespace P9_WeatherForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wather = Console.ReadLine();

            if (wather == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else 
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
