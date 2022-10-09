using System;

namespace P02_CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');


            for (int i = 0; i < secondArr.Length; i++)
            {
                string comparedElement = secondArr[i];

                for (int j = 0; j < firstArr.Length; j++)
                {                    
                    if (comparedElement == firstArr[j])
                    {
                        Console.Write(comparedElement + " ");
                    }
                }
            }
        }
    }
}
