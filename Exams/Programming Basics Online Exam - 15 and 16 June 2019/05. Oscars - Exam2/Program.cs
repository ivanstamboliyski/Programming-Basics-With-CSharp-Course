using System;

namespace _05.Oscars_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int appraiserCount = int.Parse(Console.ReadLine());

            double totalPoints = academyPoints;

            for (int appraiser = 1; appraiser <= appraiserCount; appraiser++)
            {
                string appraiserName = Console.ReadLine();
                double appraiserPoints = double.Parse(Console.ReadLine());

                totalPoints += appraiserName.Length * appraiserPoints / 2;

                if (totalPoints > 1250.5)
                {
                    break;
                }
            }

            if (totalPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - totalPoints:F1} more!");
            }
        }
    }
}
