using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (num <= 100)
            {
                bonusPoints = 5;
            }
            else if (num > 1000)
            {
                bonusPoints = num * 0.1;
            }
            else
            {
                bonusPoints = num * 0.2;
            }
            if (num % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            else if (num % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }
            
            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints + num);
        }
    }
}
