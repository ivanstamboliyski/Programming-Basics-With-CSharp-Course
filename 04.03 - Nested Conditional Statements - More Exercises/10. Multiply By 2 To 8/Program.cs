using System;

namespace _10.MultiplyBy2To8
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double result = input * 2;

            if (input < 0)
            {
                Console.WriteLine("Negative number!");
            }

            while (input >= 0)
            {
                while (input <= 8)
                {
                    Console.WriteLine($"Result: {result:F2}");
                    input = double.Parse(Console.ReadLine());
                    result = input * 2;
                    if (input < 0)
                    {
                        Console.WriteLine("Negative number!");
                    }
                }
            }
        }
    }
}
