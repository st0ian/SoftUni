using System;

namespace P7_TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int musala = 0;
            int monblan = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;


            for (int i = 0; i < groups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());

                if (peopleInGroup >= 1 && peopleInGroup <= 5)
                {
                    musala += peopleInGroup;
                }
                else if (peopleInGroup >= 6 && peopleInGroup <= 12)
                {
                    monblan += peopleInGroup;
                }
                else if (peopleInGroup >= 13 && peopleInGroup <= 25)
                {
                    kilimandjaro += peopleInGroup;
                }
                else if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    k2 += peopleInGroup;
                }
                else if (peopleInGroup > 40)
                {
                    everest += peopleInGroup;
                }
            }

            int totalPeople = musala + monblan + kilimandjaro + k2 + everest;
            double musalaPercents = ((double)musala / totalPeople) * 100;
            double monblanPercents = ((double)monblan / totalPeople) * 100;
            double kilimandjaroPercents = ((double)kilimandjaro / totalPeople) * 100;
            double k2Percents = ((double)k2 / totalPeople) * 100;
            double everestPercents = ((double)everest / totalPeople) * 100;

            Console.WriteLine($"{musalaPercents:f2}%\n{monblanPercents:f2}%\n{kilimandjaroPercents:f2}%\n{k2Percents:f2}%\n{everestPercents:f2}%");
        }
    }
}
