using System;

namespace P01_ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double discount = 0;
            double Price = 0;
            
            while (input != "special" && input != "regular")
            {
                double nextPrice = double.Parse(input);

                if (nextPrice <= 0)
                {
                    Console.WriteLine("Invalid price!");                    
                }
                else
                {
                    Price += nextPrice;
                }                

                input = Console.ReadLine();

                if (input == "special")
                {
                    discount = 0.10;
                }
            }
            
            if (Price == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {                
                double taxes = Price * 0.2;
                double priceWithTaxes = Price + taxes;
                double totalPrice = priceWithTaxes * (1 - discount);

                Console.WriteLine($"Congratulations you've just bought a new computer!{Environment.NewLine}" +
                    $"Price without taxes: {Price:f2}${Environment.NewLine}" +
                    $"Taxes: {taxes:f2}${Environment.NewLine}" +
                    $"-----------{ Environment.NewLine}" +
                    $"Total price: {totalPrice:f2}$");
            }

        }
    }
}
