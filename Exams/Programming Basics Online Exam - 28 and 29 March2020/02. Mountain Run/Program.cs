using System;

namespace _02.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double timeInSecPerMeter = double.Parse(Console.ReadLine());

            double delayInSec = Math.Floor(distanceInM / 50) * 30;
            double totalTime = distanceInM * timeInSecPerMeter + delayInSec;

            if (totalTime < recordInSec)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime - recordInSec:F2} seconds slower.");
            }
        }
    }
}
