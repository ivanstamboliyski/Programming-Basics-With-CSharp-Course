using System;

namespace _03.ExamCategories
{
    class Program
    {
        static void Main(string[] args)
        {
            int complexity = int.Parse(Console.ReadLine());
            int rotation = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());

            string category = "Regular";

            if (rotation >= 50)
            {
                if (pages >= 2)
                {
                    category = "Hard";
                }
            }
            if (complexity >= 80)
            {
                if (rotation >= 80)
                {
                    if (pages >= 8)
                    {
                        category = "Legacy";
                    }
                }
            }
            if (complexity >= 80)
            {
                if (rotation <= 10)
                {
                    category = "Master";
                }
            }
            if (complexity <= 30)
            {
                if (pages <= 1)
                {
                    category = "Easy";
                }
            }
            if (complexity <= 10)
            {
                category = "Elementary";
            }

            Console.WriteLine(category);
        }
    }
}
