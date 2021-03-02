using System;

namespace _02.LuchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());

            double luchTime = breakDuration * 1.0 / 8;
            double restTime = breakDuration * 1.0 / 4;
            double remainingTime = breakDuration - luchTime - restTime;

            if (remainingTime >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(remainingTime - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(episodeDuration - remainingTime)} more minutes.");
            }
        }
    }
}
