using System;
using System.Numerics;

namespace P11_Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());

            int snowBallSnow = 0;
            int snowBallTime = 0;
            int snowBalQualirty = 0;
            BigInteger snowballValue = BigInteger.MinusOne;

            for (int i = 0; i < balls; i++)
            {
                int tempSnowBallSnow = int.Parse(Console.ReadLine());
                int tempSsnowBallTime = int.Parse(Console.ReadLine());
                int tempSnowBalQualirty = int.Parse(Console.ReadLine());

                BigInteger tempSnowBallValue = BigInteger.Pow(tempSnowBallSnow / tempSsnowBallTime, tempSnowBalQualirty);

                if (tempSnowBallValue > snowballValue)
                {
                    snowballValue = tempSnowBallValue;
                    snowBallSnow = tempSnowBallSnow;
                    snowBallTime = tempSsnowBallTime;
                    snowBalQualirty = tempSnowBalQualirty;
                }
            }

            Console.WriteLine($"{snowBallSnow} : {snowBallTime} = {snowballValue} ({snowBalQualirty})");
        }
    }
}
