using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_TheAngryCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> priceList = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            int targetPrice = priceList[entryPoint];
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            left = priceList.GetRange(0, entryPoint);
            right = priceList.GetRange(entryPoint + 1, (priceList.Count-1) - entryPoint);

            for (int i = 0; i < left.Count; i++)
            {
                if (type == "cheap" && left[i] >= targetPrice)
                {
                        left.RemoveAt(i);
                        i--;
                }
                else if (type == "expensive" && left[i] < targetPrice)
                {
                        left.RemoveAt(i);
                        i--;
                }
            }

            for (int i = 0; i < right.Count; i++)
            {
                if (type == "cheap" && right[i] >= targetPrice)
                {
                    right.RemoveAt(i);
                    i--;
                }
                else if (type == "expensive" && right[i] < targetPrice)
                {
                    right.RemoveAt(i);
                    i--;
                }
            }

            int leftSum = left.Sum();
            int rightSum = right.Sum();

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}
