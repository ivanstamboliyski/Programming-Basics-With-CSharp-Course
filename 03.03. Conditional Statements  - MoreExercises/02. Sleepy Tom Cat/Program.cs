using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int workingDays = 365 - daysOff;
            int playingTimeInMinutes = (daysOff * 127) + (workingDays * 63);
            int difference = Math.Abs(playingTimeInMinutes - 30000);
            int hours = difference / 60;
            int minutes = difference % 60;

            if (playingTimeInMinutes > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else if (playingTimeInMinutes <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
