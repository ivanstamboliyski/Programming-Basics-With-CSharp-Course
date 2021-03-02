using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int counter = 1;
            double sumGrades = 0;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    continue;
                }

                sumGrades += grade;
                counter++;
            }

            Console.WriteLine($"{studentName} graduated. Average grade: {sumGrades / 12:F2}");
        }
    }
}
