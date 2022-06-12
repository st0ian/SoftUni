using System;

namespace P1_NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int curNum = 1;

            for (int row = 1; row <= n; row++)
            {                
                bool stop = false;

                for (int numOnRow = 1; numOnRow <= row; numOnRow++)
                {
                    Console.Write($"{curNum} ");
                    curNum++;

                    if (curNum > n)
                    {
                        stop = true;
                        break;
                    }
                }
                if (stop)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
