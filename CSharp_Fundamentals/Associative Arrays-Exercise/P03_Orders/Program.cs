using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, int>> orders =
               new Dictionary<string, Dictionary<double, int>>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] ordersArg = input.Split();
                string item = ordersArg[0];
                double price = double.Parse(ordersArg[1]);
                int quanity = int.Parse(ordersArg[2]);

                // Add new item if it is Not in the Dictionary
                if (!orders.ContainsKey(item))
                {
                    orders.Add(item, new Dictionary<double, int>());
                }
                // Add the price as key for the nested Dictionary if there is No such price
                if (!orders[item].ContainsKey(price))
                {
                    orders[item].Add(price, 0);
                }

                // Store all price-quantity inputs for the item in the nested Dictionary
                orders[item][price] +=  quanity;

                input = Console.ReadLine();
            }

            foreach (var kvp in orders)
            {
                string item = kvp.Key;

                // take last price for the item and sum qunatities
                var price = kvp.Value.Keys.Last();
                var quantity = kvp.Value.Values.Sum();
                var totalPrice = price * quantity;

                Console.WriteLine($"{item} -> {totalPrice:f2}");
            }
        }
    }
}
