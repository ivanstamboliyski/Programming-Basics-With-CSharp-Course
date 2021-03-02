using System;

namespace ProgrammingBasicsOnlineExam_15and16June2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int seasonsCount = int.Parse(Console.ReadLine());
            int episodesCount = int.Parse(Console.ReadLine());
            int regularEpisodeTime = int.Parse(Console.ReadLine());

            double fullTimeEpisode = regularEpisodeTime * 1.20;
            double lastEpisodeTime = seasonsCount * 10;

            double totalTime = seasonsCount * episodesCount * fullTimeEpisode + lastEpisodeTime;

            Console.WriteLine($"Total time needed to watch the {serialName} series is {Math.Floor(totalTime)} minutes.");
        }
    }
}
