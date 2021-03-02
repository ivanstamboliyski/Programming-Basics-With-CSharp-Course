using System;

namespace _04.MetricConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double metric = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "mm")
            {
                metric = metric / 1000;
            }
            else if (input == "cm")
            {
                metric = metric / 100;
            }
            else if (input == "m")
            {
                metric = metric / 1;
            }
            if (output == "mm")
            {
                metric = metric * 1000;
            }
            else if (output == "cm")
            {
                metric = metric * 100;
            }
            else if (true)
            {
                metric = metric * 1;
            }

            Console.WriteLine($"{ metric:F3}");


        }
    }
}
