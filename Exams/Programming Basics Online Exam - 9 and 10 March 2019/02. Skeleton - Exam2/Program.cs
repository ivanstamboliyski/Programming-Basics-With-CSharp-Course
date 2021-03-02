using System;

namespace _02.Skeleton_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlTimeMinuts = int.Parse(Console.ReadLine());
            int controlTimeSeconds = int.Parse(Console.ReadLine());
            double lenghtInMeters = double.Parse(Console.ReadLine());
            int timePer100MInSeconds = int.Parse(Console.ReadLine());

            int controlTimeInSeconds = controlTimeMinuts * 60 + controlTimeSeconds;
            double delayInSeconds = (lenghtInMeters / 120) * 2.5;
            double finalTime = (lenghtInMeters / 100) * timePer100MInSeconds - delayInSeconds;

            if (finalTime <= controlTimeInSeconds)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {finalTime:F3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {finalTime - controlTimeInSeconds:F3} second slower.");
            }
        }
    }
}
