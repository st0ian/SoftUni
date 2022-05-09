using System;

internal class Program
{
    static void Main(string[] args)
    {
        int score = int.Parse(Console.ReadLine());
        
        double bonus = 0.0;
                
        if (score <= 100)
        {
            bonus=5;
        }
        else if(score>100 && score<1000)
        {
            bonus=0.2*score;
        }
        else
        {
            bonus = 0.1 * score;
        }

        int additionalBonus=0;

        if (score%2 == 0)
        {
            additionalBonus=1;
        }
        else if (score%10 ==5)
        {
            additionalBonus = 2;
        }

        Console.WriteLine(bonus + additionalBonus);
        Console.WriteLine(score + bonus + additionalBonus);
    }
}
