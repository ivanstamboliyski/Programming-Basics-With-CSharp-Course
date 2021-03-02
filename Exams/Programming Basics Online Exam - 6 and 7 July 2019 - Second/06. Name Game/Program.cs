using System;

namespace _06.NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            string winner = "";
            int winnerPoints = int.MinValue;

            while (playerName != "Stop")
            {
                int pointsPerPlayer = 0;

                for (int currDigit = 0; currDigit < playerName.Length; currDigit++)
                {
                    int numPerCurrDigit = int.Parse(Console.ReadLine());

                    if (numPerCurrDigit == playerName[currDigit])
                    {
                        pointsPerPlayer += 10;
                    }
                    else
                    {
                        pointsPerPlayer += 2;
                    }
                }
                if (pointsPerPlayer >= winnerPoints)
                {
                    winnerPoints = pointsPerPlayer;
                    winner = playerName;
                }

                playerName = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {winner} with {winnerPoints} points!");
        }
    }
}
