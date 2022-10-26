using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int length = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < length; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);                
            }

            if (firstList.Count > secondList.Count)
            {
                for (int j = length ; j < firstList.Count; j++)
                {
                    result.Add(firstList[j]);
                }
            }
            else
            {
                for (int j = length; j < secondList.Count; j++)
                {
                    result.Add(secondList[j]);
                }
            }

            Console.WriteLine(String.Join(" ",result));
        }
    }
}
