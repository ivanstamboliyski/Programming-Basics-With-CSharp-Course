using System;

namespace _06.SpecialNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1111; i <= 9999; i++)
            {
                int currNum = i;

                for (int j = 1; j <= 4; j++)
                {
                    int currDigit = currNum % 10;

                    if (currDigit != 0)
                    {
                        if (n % currDigit == 0)
                        {
                            counter++;
                        }
                    }

                    currNum /= 10;

                    if (counter == 4)
                    {
                        Console.Write(i + " ");
                    }
                }
                counter = 0;
            }
        }
    }
}
