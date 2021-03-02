using System;

namespace _06.EasterCompetition_Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kozunaksCount = int.Parse(Console.ReadLine());

            int maxPoints = int.MinValue;
            string winner = "";

            for (int kozunak = 1; kozunak <= kozunaksCount; kozunak++)
            {
                string bakerName = Console.ReadLine();
                string pointsPerKozunak = Console.ReadLine();
                int allPointsPerKozunak = 0;

                while (pointsPerKozunak != "Stop")
                {
                    allPointsPerKozunak += int.Parse(pointsPerKozunak);

                    pointsPerKozunak = Console.ReadLine();
                }
                Console.WriteLine($"{bakerName} has {allPointsPerKozunak} points.");
                if (allPointsPerKozunak > maxPoints)
                {
                    Console.WriteLine($"{bakerName} is the new number 1!");
                    maxPoints = allPointsPerKozunak;
                    winner = bakerName;
                }
            }

            Console.WriteLine($"{winner} won competition with {maxPoints} points!");
        }
    }
}
