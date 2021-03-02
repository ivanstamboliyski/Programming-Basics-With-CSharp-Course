using System;

namespace _04._4._TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());

            string presentationName = Console.ReadLine();

            double gradesForAllPresentation = 0;
            int presentationCount = 0;

            while (presentationName != "Finish")
            {
                presentationCount++;

                double gradeForCurrentPresentation = 0;
                double gradesForPresentation = 0;

                for (int i = 1; i <= juryCount; i++)
                {
                    gradeForCurrentPresentation = double.Parse(Console.ReadLine());
                    gradesForPresentation += gradeForCurrentPresentation;
                    gradesForAllPresentation += gradeForCurrentPresentation;
                }

                Console.WriteLine($"{presentationName} - {gradesForPresentation / juryCount:F2}.");

                presentationName = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {gradesForAllPresentation / (presentationCount * juryCount):F2}.");
        }
    }
}
