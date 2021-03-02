using System;

namespace _04.GameNumberWars_Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();

            string firstPlayerCard = Console.ReadLine();
            string secondPlayerCard = Console.ReadLine();

            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;
            bool numberWars = false;
            string winner = "";
            int winnerPoints = 0;

            while (secondPlayerCard != "End of game")
            {
                int value1 = int.Parse(firstPlayerCard);
                int value2 = int.Parse(secondPlayerCard);

                if (numberWars)
                {
                    if (value1 > value2)
                    {
                        winner = firstPlayerName;
                        winnerPoints = firstPlayerPoints;
                    }
                    else
                    {
                        winner = secondPlayerName;
                        winnerPoints = secondPlayerPoints;
                    }
                    break;
                }

                if (value1 > value2)
                {
                    firstPlayerPoints += value1 - value2;
                }
                else if (value2 > value1)
                {
                    secondPlayerPoints += value2 - value1;
                }
                else
                {
                    numberWars = true;
                }

                firstPlayerCard = Console.ReadLine();
                if (firstPlayerCard == "End of game")
                {
                    break;
                }
                secondPlayerCard = Console.ReadLine();
            }

            if (numberWars)
            {
                Console.WriteLine("Number wars!");
                Console.WriteLine($"{winner} is winner with {winnerPoints} points");
            }
            else
            {
                Console.WriteLine($"{firstPlayerName} has {firstPlayerPoints} points");
                Console.WriteLine($"{secondPlayerName} has {secondPlayerPoints} points");
            }
        }
    }
}
