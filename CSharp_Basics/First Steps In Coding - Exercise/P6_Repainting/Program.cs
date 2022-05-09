using System;

namespace P6_Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int requiredNylon = int.Parse(Console.ReadLine());
            int requiredPaint = int.Parse(Console.ReadLine());
            int requiredThinner = int.Parse(Console.ReadLine());
            int requiredHours = int.Parse(Console.ReadLine());

            const double priceOfNylon = 1.50;
            const double priceOfPaint = 14.50;
            const double priceOfThinner = 5.00;

            double reservePaint = requiredPaint * 0.10;
            int reserveNylon = 2;
            double billBags = 0.40;
            double hourlyRateWorker;

            double billNylon = (requiredNylon + reserveNylon) * priceOfNylon;
            double billPaint = (requiredPaint + reservePaint) * priceOfPaint;
            double billThinner = requiredThinner * priceOfThinner;

            double billMaterials = billNylon + billPaint + billThinner + billBags;
            hourlyRateWorker = billMaterials * 0.30;
            double billWorker = hourlyRateWorker * requiredHours;

            double totalBill = billMaterials + billWorker;

            Console.WriteLine(totalBill);
        }
    }
}