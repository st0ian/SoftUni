using System;

namespace P09_PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 90 / 100 in Judge

            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float saberPrice = float.Parse(Console.ReadLine());
            float robePrice = float.Parse(Console.ReadLine());
            float beltPrice = float.Parse(Console.ReadLine());

            double totalCost = 0;

            int totalSabers = (int)(Math.Ceiling(students * 1.1));
            int freeBelts = students / 6;
            int totalBelts = students - freeBelts;

            totalCost = totalSabers * saberPrice + students * robePrice + totalBelts * beltPrice;

            if (money >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalCost-money):f2}lv more.");
            }
        }
    }
}
