using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            double savedMoney = 0;

            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());

                while (savedMoney < minBudget)
                {
                    double currSum = double.Parse(Console.ReadLine());
                    savedMoney += currSum;

                    if (savedMoney >= minBudget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        savedMoney = 0;
                        break;
                    }
                }

                destination = Console.ReadLine();
            }
        }
    }
}
