using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int spendCounter = 0;
            int daysCounter = 0;

            while (availableMoney < neededMoney && spendCounter < 5)
            {
                string input = Console.ReadLine();
                double dailySum = double.Parse(Console.ReadLine());
                daysCounter++;

                if (input == "spend")
                {
                    spendCounter++;
 
                    if (dailySum > availableMoney)
                    {
                        availableMoney -= availableMoney;
                    }
                    else
                    {
                        availableMoney -= dailySum;
                    }
                }
                else if (input == "save")
                {
                    availableMoney += dailySum;
                    spendCounter = 0;
                } 
            }

            if (spendCounter >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
