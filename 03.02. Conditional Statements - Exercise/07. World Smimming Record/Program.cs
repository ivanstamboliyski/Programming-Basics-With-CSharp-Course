using System;

namespace _07.WorldSmimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
        
            double worldRecord = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecPer1Meter = double.Parse(Console.ReadLine());

            double timeWithoutDelay = timeInSecPer1Meter * distanceInMeters;
            double delay = (Math.Floor(distanceInMeters / 15) * 12.5);
            double finalTime = timeWithoutDelay + delay;

            if (finalTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:F2} seconds."); 
            }
            else if (finalTime >= worldRecord)
            {
                double secondsSlower = finalTime - worldRecord;
                Console.WriteLine($"No, he failed! He was {secondsSlower:F2} seconds slower.");
            }




        }
    }
}
