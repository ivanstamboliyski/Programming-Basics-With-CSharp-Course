using System;

namespace _05.FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int mathesPlayed = int.Parse(Console.ReadLine());

            int winCounter = 0;
            int drawCounter = 0;
            int lostCounter = 0;
            int points = 0;

            for (int match = 1; match <= mathesPlayed; match++)
            {
                char result = char.Parse(Console.ReadLine());

                if (result == 'W')
                {
                    winCounter++;
                    points += 3;
                }
                else if (result == 'D')
                {
                    drawCounter++;
                    points += 1;
                }
                else
                {
                    lostCounter++; 
                } 
            }

            if (mathesPlayed == 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
            }
            else
            {
                Console.WriteLine($"{teamName} has won {points} points during this season.");
                Console.WriteLine($"Total stats:");
                Console.WriteLine($"## W: {winCounter}");
                Console.WriteLine($"## D: {drawCounter}");
                Console.WriteLine($"## L: {lostCounter}");
                Console.WriteLine($"Win rate: {winCounter * 1.0 / mathesPlayed * 100:F2}%");
            }
        }
    }
}
