using System;

namespace _10.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1LevaCoins = int.Parse(Console.ReadLine());
            int count2LevaCoins = int.Parse(Console.ReadLine());
            int count5LevaBill = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int currCount1 = 0; currCount1 <= count1LevaCoins; currCount1++)
            {
                for (int currCount2 = 0; currCount2 <= count2LevaCoins; currCount2++)
                {
                    for (int currCount5 = 0; currCount5 <= count5LevaBill; currCount5++)
                    {
                        if ((currCount1 * 1) + (currCount2 * 2) + (currCount5 * 5) == sum)
                        {
                            Console.WriteLine($"{currCount1} * 1 lv. + {currCount2} * 2 lv. + {currCount5} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
