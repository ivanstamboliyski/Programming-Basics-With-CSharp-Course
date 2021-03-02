using System;

namespace _02.MovieDay_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededDuration = int.Parse(Console.ReadLine());
            int scenesCount = int.Parse(Console.ReadLine());
            int sceneDuration = int.Parse(Console.ReadLine());

            double prepareTime = neededDuration * 0.15;
            double allScenesDuration = scenesCount * sceneDuration;
            double totalTime = allScenesDuration + prepareTime;

            if (neededDuration >= totalTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(neededDuration - totalTime)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(totalTime - neededDuration)} minutes.");
            }
        }
    }
}
