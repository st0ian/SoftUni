using System;

namespace P5_Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            decimal twoLeva = 2m;
            decimal oneLev = 1m;
            decimal st50 = 0.5m;
            decimal st20 = 0.2m;
            decimal st10 = 0.1m;
            decimal st5 = 0.05m;
            decimal st2 = 0.02m;
            decimal st1 = 0.01m;
            int count = 0;

            while (change > 0)
            {
                if (change >= twoLeva)
                {
                    change -= twoLeva;
                }
                else if (change >= oneLev)
                {
                    change -= oneLev;
                }
                else if (change >= st50)
                {
                    change -= st50;
                }
                else if (change >= st20)
                {
                    change -= st20;
                }
                else if (change >= st10)
                {
                    change -= st10;
                }
                else if (change >= st5)
                {
                    change -= st5;
                }
                else if (change >= st2)
                {
                    change -= st2;
                }
                else if (change >= st1)
                {
                    change -= st1;
                }

                count++;
            }
            
            Console.WriteLine(count);
        }
    }
}
