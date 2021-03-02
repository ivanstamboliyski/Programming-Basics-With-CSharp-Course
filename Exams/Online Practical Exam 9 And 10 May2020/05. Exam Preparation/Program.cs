using System;

namespace _05.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int problemsCount = int.Parse(Console.ReadLine());
            int trainerPower = int.Parse(Console.ReadLine());

            int problemsCounter = 0;
            int questionsCounter = 0;
            bool end = false;

            while (trainerPower > 0)
            {
                problemsCounter += problemsCount;
                trainerPower += problemsCount * 2;
                studentsCount -= problemsCount;

                if (studentsCount < 10)
                {
                    Console.WriteLine("The students are too few!");
                    Console.WriteLine($"Problems solved: {problemsCounter}");
                    end = true;
                    break;
                }

                questionsCounter += studentsCount * 2;
                studentsCount += studentsCount / 10;
                trainerPower -= questionsCounter * 3;
            }

            if (!end)
            {
                Console.WriteLine("The trainer is too tired!");
                Console.WriteLine($"Questions answered: {questionsCounter}");
            }
        }
    }
}
