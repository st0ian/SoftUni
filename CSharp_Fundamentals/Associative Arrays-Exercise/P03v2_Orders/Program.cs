using System;
using System.Collections.Generic;

namespace P03v2_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> orders = new Dictionary<string, double[]>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] ordersArg = input.Split();
                string item = ordersArg[0];
                double price = double.Parse(ordersArg[1]);
                int quanity = int.Parse(ordersArg[2]);

                if (!orders.ContainsKey(item))
                {
                    orders.Add(item, new double[2]);
                }

                double[] ammounts = orders[item];
                ammounts[0] = price;
                ammounts[1] += quanity;

                input = Console.ReadLine();
            }

            foreach (var kvp in orders)
            {
                var item = kvp.Key;
                var totalPrice = kvp.Value[0] * kvp.Value[1];

                Console.WriteLine($"{item} -> {totalPrice:f2}");
            }
        }
    }
}
