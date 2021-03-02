using System;

namespace _06.TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int winDaysCounter = 0;
            double totalIncome = 0;
            for (int day = 1; day <= daysCount; day++)
            {
                string sport = Console.ReadLine();
                double dayWin = 0;
                int winCounter = 0;
                int lostCounter = 0;
                while (sport != "Finish")
                {
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        dayWin += 20;
                        winCounter++;
                    }
                    else
                    {
                        lostCounter++;
                    }
                    sport = Console.ReadLine();
                }
                if (winCounter > lostCounter)
                {
                    dayWin *= 1.10;
                    winDaysCounter++;
                }
                totalIncome += dayWin;
            }
            if (winDaysCounter > (daysCount - winDaysCounter))
            {
                totalIncome *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalIncome:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalIncome:F2}");
            }
        }
    }
}
