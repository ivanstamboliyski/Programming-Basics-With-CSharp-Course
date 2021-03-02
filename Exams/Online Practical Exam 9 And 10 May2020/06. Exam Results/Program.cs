using System;

namespace _06.ExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            bool cheating = false;

            while (studentName != "Midnight")
            {
                double studentPoints = 0;

                for (int problem = 1; problem <= 6; problem++)
                {
                    int problemPoints = int.Parse(Console.ReadLine());

                    if (problemPoints < 0)
                    {
                        Console.WriteLine($"{studentName} was cheating!");
                        cheating = true;
                        break;
                    }

                    studentPoints += problemPoints;
                }
          
                double grade = Math.Floor(studentPoints / 6) * 0.06;

                if (grade < 3)
                {
                    grade = 2.00;
                }

                if (grade >= 5)
                {
                    Console.WriteLine("===================");
                    Console.WriteLine("|   CERTIFICATE   |");
                    Console.WriteLine($"|    { grade:F2}/6.00    |");
                    Console.WriteLine("===================");
                    Console.WriteLine($"Issued to {studentName}");
                }
                else if (!cheating)
                {
                    Console.WriteLine($"{studentName} - {grade:F2}");
                }

                studentName = Console.ReadLine();
            }
        }
    }
}
