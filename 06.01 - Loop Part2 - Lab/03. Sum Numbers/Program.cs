using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;

            while (input != "Stop")
            {
                sum += int.Parse(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
