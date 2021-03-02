using System;

namespace _05.FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentCount = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            int tournamentPoints = 0;
            int winCounter = 0;

            for (int tournaments = 1; tournaments <= tournamentCount; tournaments++)
            {
                string stage = Console.ReadLine();

                if (stage == "W")
                {
                    winCounter++;
                    tournamentPoints += 2000;
                }
                else if (stage == "F")
                {
                    tournamentPoints += 1200;
                }
                else
                {
                    tournamentPoints += 720;
                }
            }

            int finalPoints = startPoints + tournamentPoints;
            double averagePoints = tournamentPoints * 1.0 / tournamentCount;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{(winCounter * 1.0 / tournamentCount) * 100:F2}%");
        }
    }
}
