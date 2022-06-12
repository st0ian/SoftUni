using System;

namespace P3_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                        
            int count = 0;  
            
            for (int a = 0; a <= n; a++)
            {
                int sum = 0;
                for (int b = 0; b <= n; b++)
                {
                    for (int c = 0; c <= n; c++)
                    {
                        sum = a + b + c;
                        if (sum == n)
                        {
                            count++;    
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
