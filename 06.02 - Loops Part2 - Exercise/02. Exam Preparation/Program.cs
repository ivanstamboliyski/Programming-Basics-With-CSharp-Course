using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());

            int badGradesCounter = 0;
            int problemCounter = 0;
            string lastProblem = "";
            double sumGrades = 0;

            string problemName = Console.ReadLine();

            while (problemName != "Enough")
            {
                int currGrade = int.Parse(Console.ReadLine());
                problemCounter++;
                lastProblem = problemName;
                sumGrades += currGrade;

                if (currGrade <= 4)
                {
                    badGradesCounter++;
                    if (badGradesCounter >= badGrades)
                    {
                        break;
                    }
                }
                
                problemName = Console.ReadLine();
            }

            if (problemName == "Enough")
            {
                Console.WriteLine($"Average score: {sumGrades / problemCounter:F2}");
                Console.WriteLine($"Number of problems: {problemCounter}");
                Console.WriteLine($"Last problem: {lastProblem}"); 
            }
            else
            {
                Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
            }
        }
    }
}
