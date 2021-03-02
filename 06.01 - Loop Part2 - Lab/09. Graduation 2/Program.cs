using System;

namespace _09.Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int counter = 1;
            double sumGrades = 0;
            int fail = 0;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    fail++;
                    if (fail > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {counter} grade");
                        return;
                    }
                    continue;
                }

                sumGrades += grade;
                counter++;
            }

            Console.WriteLine($"{studentName} graduated. Average grade: {sumGrades / 12:F2}");
        }
    }
}
