using System;

namespace _06.BasketballTournament_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournamentName = Console.ReadLine();
            int matchCounter = 0;
            int winCounter = 0;
            int lostCounter = 0;

            while (tournamentName != "End of tournaments")
            {
                int matchesCount = int.Parse(Console.ReadLine());
                int currMatchCounter = 0;

                for (int match = 1; match <= matchesCount; match++)
                {
                    int pointsTeam1 = int.Parse(Console.ReadLine());
                    int pointsTeam2 = int.Parse(Console.ReadLine());
                    currMatchCounter++;
                    matchCounter++;
                    if (pointsTeam1 > pointsTeam2)
                    {
                        Console.WriteLine($"Game {currMatchCounter} of tournament {tournamentName}: win with {pointsTeam1 - pointsTeam2} points.");
                        winCounter++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {currMatchCounter} of tournament {tournamentName}: lost with {pointsTeam2 - pointsTeam1} points.");
                        lostCounter++;
                    }
                }
                tournamentName = Console.ReadLine();
            }

            Console.WriteLine($"{winCounter * 1.0 / matchCounter * 100:F2}% matches win");
            Console.WriteLine($"{lostCounter * 1.0 / matchCounter * 100:F2}% matches lost");
        }
    }
}
