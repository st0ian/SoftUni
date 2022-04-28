using System;

internal class Program
{
    static void Main(string[] args)
    {
        double squareM = double.Parse(Console.ReadLine());

        const double pricePerSquareM = 7.61;
        const double discountPercent = 0.18;

        double sum = squareM * pricePerSquareM;
        double discount = sum * discountPercent;
        double bill = sum - discount;

        Console.WriteLine($"The final price is: {bill} lv.\nThe discount is: {discount} lv.");
    }
}
