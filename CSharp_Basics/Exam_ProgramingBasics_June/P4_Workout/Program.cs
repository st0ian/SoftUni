using System;

namespace P4_Workout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double startingKms = double.Parse(Console.ReadLine());

            double currentKms = startingKms;
            double totalKms = startingKms;

            for (int i = 1; i <= days; i++)
            {
                int daylyPercantage = int.Parse(Console.ReadLine());
                double daylyKms = currentKms + daylyPercantage * currentKms / 100;

                currentKms = daylyKms;
                totalKms += daylyKms;
            }

            if (totalKms > +1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKms - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalKms)} more kilometers");
            }
        }
    }
}
