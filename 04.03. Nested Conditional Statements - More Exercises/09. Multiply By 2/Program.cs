using System;

namespace _09.Multiply_By_2
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
