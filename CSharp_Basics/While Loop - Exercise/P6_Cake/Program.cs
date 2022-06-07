using System;

namespace P6_Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int piecesTotal = width * length;

            string input = Console.ReadLine();
            int piecesNeeded = 0;
            bool stop = true;

            while (input != "STOP")
            {                
                int piecesNext = int.Parse(input);

                piecesTotal -= piecesNext;
                if (piecesTotal <= 0)
                {
                    piecesNeeded = Math.Abs(piecesTotal);
                    stop = false;
                    break;
                }
                input = Console.ReadLine();
            }
            if (!stop)
            {
                Console.WriteLine($"No more cake left! You need {piecesNeeded} pieces more.");
            }
            else
            {
                Console.WriteLine($"{piecesTotal} pieces are left.");
            }
        }
    }
}
