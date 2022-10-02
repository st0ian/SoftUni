using System;

namespace P07_VendingMachine
{
    internal class Program
    {
        // Needs debuging -- sth in the while logics

        static void Main(string[] args)
        {
            double priceNuts = 2.0;
            double priceWater = 0.7;
            double priceCrisps = 1.5;
            double priceSoda = 0.8;
            double priceCoke = 1.0;

            string command;
            string command2;
            double sum = 0;

            while ((command = Console.ReadLine()) != "Start")
            {
                double nextCoin = double.Parse(command);

                if (nextCoin == 0.1 || nextCoin == 0.2 || nextCoin == 0.5 || nextCoin == 1 || nextCoin == 2)
                {
                    sum += nextCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {nextCoin}");
                }

                command = Console.ReadLine();
            }

            
            while ((command2 = Console.ReadLine()) != "End")
            {
                string selectedItem = command2;

                switch (selectedItem)
                {
                    case "Nuts":
                        Console.WriteLine($"Purchased {selectedItem}");
                        sum -= priceNuts;
                        break;
                    case "Water":
                        Console.WriteLine($"Purchased {selectedItem}");
                        sum -= priceWater;
                        break;
                    case "Crisps":
                        Console.WriteLine($"Purchased {selectedItem}");
                        sum -= priceCrisps;
                        break;
                    case "Soda":
                        Console.WriteLine($"Purchased {selectedItem}");
                        sum -= priceSoda;
                        break;
                    case "Coke":
                        Console.WriteLine($"Purchased {selectedItem}");
                        sum -= priceCoke;
                        break;
                    default:
                        Console.WriteLine($"Invalid product");
                        break;
                }     
                
                command2 = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum}");
        }
    }
}
