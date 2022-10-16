using System;
using System.Linq;

namespace P09_KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] bestDna = new int[length];

            int bestSample = -1;
            int bestSum = 0;
            int bestIndex = -1;

            int bestTotalSum = 0;
            int curBestTotalSum = 0;

            int curSample = 0;
            string command;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] curDna = command.Split('!').Select(int.Parse).ToArray();

                curSample++;

                int curSum = 0;
                int totalSum = 0;

                bool isBest = false;
                bool isUnique = true;
                int curIndex = -1;

                for (int i = 0; i < curDna.Length; i++)
                {
                    if (curDna[i] == 1)
                    {
                        if (i == 0)
                        {
                            curIndex = i;
                        }
                        else if (curDna[i - 1] == 0)
                        {
                            curIndex = i;
                        }

                        curSum++;
                        totalSum++;
                    }

                    if (curDna[i] != 1)
                    {
                        if (curSum > bestSum || (curSum == bestSum && curIndex < bestIndex))
                        {
                            bestSum = curSum;
                            bestSample = curSample;
                            isBest = true;
                            bestIndex = curIndex;
                            curBestTotalSum = totalSum;
                        }

                        else if (curSum == bestSum && curIndex == bestIndex)
                        {
                            isUnique = false;
                        }

                        curSum = 0;
                    }
                }                

                if (isBest)
                {
                    curBestTotalSum = totalSum;
                    bestDna = curDna;

                    if (isUnique)
                    {
                        bestTotalSum = curBestTotalSum;
                    }
                }

                if (!isUnique)
                {
                    curBestTotalSum = totalSum;

                    if (curBestTotalSum > bestTotalSum)
                    {
                        bestDna = curDna;
                        bestTotalSum = curBestTotalSum;
                        bestSample = curSample;
                    }

                    bestSum = bestTotalSum;
                }

                isUnique = true;
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}
