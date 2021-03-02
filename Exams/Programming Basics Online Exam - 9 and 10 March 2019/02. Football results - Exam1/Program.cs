using System;

namespace _02.Footballresults_Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstGameResult = Console.ReadLine(); 
            string secondGameResult = Console.ReadLine(); 
            string thirdGameResult = Console.ReadLine();

            int winCounter = 0;
            int lostCounter = 0;
            int drawCounter = 0;

            char firstDigitFirstGame = firstGameResult[0];
            char secondDigitFirstGame = firstGameResult[2];

            if (firstDigitFirstGame > secondDigitFirstGame)
            {
                winCounter++;
            }
            else if (firstDigitFirstGame < secondDigitFirstGame)
            {
                lostCounter++;
            }
            else
            {
                drawCounter++;
            }

            char firstDigitSecondGame = secondGameResult[0];
            char secondDigitSecondGame = secondGameResult[2];

            if (firstDigitSecondGame > secondDigitSecondGame)
            {
                winCounter++;
            }
            else if (firstDigitSecondGame < secondDigitSecondGame)
            {
                lostCounter++;
            }
            else
            {
                drawCounter++;
            }

            char firstDigitThirdGame = thirdGameResult[0];
            char secondDigitThirdGame = thirdGameResult[2];

            if (firstDigitThirdGame > secondDigitThirdGame)
            {
                winCounter++;
            }
            else if (firstDigitThirdGame < secondDigitThirdGame)
            {
                lostCounter++;
            }
            else
            {
                drawCounter++;
            }

            Console.WriteLine($"Team won {winCounter} games.");
            Console.WriteLine($"Team lost {lostCounter} games.");
            Console.WriteLine($"Drawn games: {drawCounter}");
        }
    }
}
