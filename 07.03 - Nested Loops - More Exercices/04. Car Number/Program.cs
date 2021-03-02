using System;

namespace _04.CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            bool condition1 = false;
            bool condition2 = false;
            bool condition3 = false;

            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    for (int num3 = start; num3 <= end; num3++)
                    {
                        for (int num4 = start; num4 <= end; num4++)
                        {
                            if ((num1 % 2 == 0 && num4 % 2 != 0) || (num1 % 2 != 0 && num4 % 2 == 0))
                            {
                                condition1 = true;
                            }
                            if (num1 > num4)
                            {
                                condition2 = true;
                            }
                            if ((num2 + num3) % 2 == 0)                
                            {
                                condition3 = true;
                            }

                            if (condition1 && condition2 && condition3)
                            {
                                Console.Write($"{num1}{num2}{num3}{num4} ");
                            }

                            condition1 = false;
                            condition2 = false;
                            condition3 = false;
                        }
                    }
                }
            }
        }
    }
}
