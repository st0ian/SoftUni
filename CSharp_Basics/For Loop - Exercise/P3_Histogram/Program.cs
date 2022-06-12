using System;

namespace P3_Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2= 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int nextNumber = int.Parse(Console.ReadLine());

                if (nextNumber< 200)
                {
                    p1++;
                }
                else if (nextNumber >= 200 && nextNumber <= 399)
                {
                    p2++;
                }
                else if (nextNumber >= 400 && nextNumber <= 599)
                {
                    p3++;
                }
                else if (nextNumber >= 600 && nextNumber <= 799)
                {
                    p4++;
                }
                else if (nextNumber >= 800)
                {
                    p5++;
                }
            }

            double percentsP1 = (p1 / n) * 100;
            double percentsP2 = (p2 / n) * 100;
            double percentsP3 = (p3 / n) * 100;
            double percentsP4 = (p4 / n) * 100;
            double percentsP5 = (p5 / n) * 100;
            Console.WriteLine($"{percentsP1:f2}%\n{percentsP2:f2}%\n{percentsP3:f2}%\n{percentsP4:f2}%\n{percentsP5:f2}%");  
        }
    }
}
