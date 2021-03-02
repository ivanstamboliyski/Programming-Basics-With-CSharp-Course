using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsNumber = int.Parse(Console.ReadLine());

            double sumGrades = 0;
            int studentsFail = 0;
            int studentsGroup2 = 0;
            int studentsGroup3 = 0;
            int topStudents = 0;

            for (int students = 1; students <= studentsNumber; students++)
            {
                double grade = double.Parse(Console.ReadLine());

                sumGrades += grade;

                if (grade < 3.00)
                {
                    studentsFail++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    studentsGroup2++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    studentsGroup3++;
                }
                else
                {
                    topStudents++;
                }
            }

            double percentTopStudents = topStudents * 1.0 / studentsNumber * 100;
            double percentstudentsGroup3 = studentsGroup3 * 1.0 / studentsNumber * 100;
            double percentstudentsGroup2 = studentsGroup2 * 1.0 / studentsNumber * 100;
            double percentstudentsFail = studentsFail * 1.0 / studentsNumber * 100;

            double averageGrades = sumGrades / studentsNumber;

            Console.WriteLine($"Top students: {percentTopStudents:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentstudentsGroup3:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentstudentsGroup2:F2}%");
            Console.WriteLine($"Fail: {percentstudentsFail:F2}%");
            Console.WriteLine($"Average: {averageGrades:f2}");

        }
    }
}
