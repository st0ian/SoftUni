using System;

namespace P8_OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examStartHour = int.Parse(Console.ReadLine());
            int examStartMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            bool onTime = false;
            bool early = false;
            bool late = false;
            bool inHours = false;

            int diferenceHours = 0;
            int diferenceMinutes = 0;

            if (examStartHour >= arrivalHour)
            {
                int extraTime = (examStartHour - arrivalHour) * 60;

                if (examStartHour == arrivalHour & examStartMinutes == arrivalMinutes)
                {
                    Console.WriteLine("On time");
                }

                else if (examStartMinutes >= arrivalMinutes - extraTime)
                {                    
                    if ((examStartMinutes - arrivalMinutes + extraTime) <= 30)
                    {
                        onTime = true;
                    }
                    else if ((examStartMinutes - arrivalMinutes + extraTime) > 30)
                    {
                        early = true;
                    }
                }
                else
                {
                    late = true;
                }
            }
            else
            {
                late = true;
            }

            int difference = Math.Abs((examStartHour - arrivalHour) * 60 + examStartMinutes - arrivalMinutes);
            if (difference >= 60)
            {
                diferenceHours = difference / 60;
                diferenceMinutes = difference % 60;
                inHours = true;
            }

            if (late)
            {
                if (inHours)
                {
                    Console.WriteLine($"Late\n{diferenceHours}:{diferenceMinutes:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"Late\n{difference} minutes after the start");
                }
            }


            else if (onTime)
            {
                if (inHours)
                {
                    Console.WriteLine($"On time\n{diferenceHours}:{diferenceMinutes:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"On time\n{difference} minutes before the start");
                }
            }

            else if (early)
            {
                if (inHours)
                {
                    Console.WriteLine($"Early\n{diferenceHours}:{diferenceMinutes:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"Early\n{difference} minutes before the start");
                }
            }
        }
    }
}
