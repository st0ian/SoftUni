using System;

namespace P2_SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degress = double.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();


            string outfit = "";
            string shoes = "";

            if (degress >= 10 && degress <= 18)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degress > 18 && degress <= 24)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degress > 24)
            {
                if (partOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (partOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (partOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {degress} degrees, get your {outfit} and {shoes}.");
        }
    }
}
