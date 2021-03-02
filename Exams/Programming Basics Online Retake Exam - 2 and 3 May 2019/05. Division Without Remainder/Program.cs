using System;

namespace _05.DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNums = int.Parse(Console.ReadLine());

            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;

            for (int num = 1; num <= countNums; num++)
            {
                int currNum = int.Parse(Console.ReadLine());

                if (currNum % 2 == 0)
                {
                    counter2++;
                }
                if (currNum % 3 == 0)
                {
                    counter3++;
                }
                if (currNum % 4 == 0)
                {
                    counter4++;
                }
            }

            Console.WriteLine($"{counter2 * 1.0 / countNums * 100:F2}%");
            Console.WriteLine($"{counter3 * 1.0 / countNums * 100:F2}%");
            Console.WriteLine($"{counter4 * 1.0 / countNums * 100:F2}%");
        }
    }
}
