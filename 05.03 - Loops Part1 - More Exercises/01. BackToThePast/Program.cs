using System;

namespace _05.LoopsPart1_MoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            double moneyForEvenYears = 0;
            double moneyForOddYears = 0;
            int yearsOld = 17;

            for (int i = 1800; i <= year; i++)
            {
                yearsOld++; 

                if (i % 2 == 0)
                {
                    moneyForEvenYears += 12000;
                }
                else if (i % 2 != 0)
                {
                    moneyForOddYears += 12000 + 50 * yearsOld;
                }
            }

            double totalMoney = moneyForEvenYears + moneyForOddYears;
            double difference = Math.Abs(totalMoney - money);

            if (totalMoney <= money)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {difference:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {difference:F2} dollars to survive.");
            }


        }
    }
}
