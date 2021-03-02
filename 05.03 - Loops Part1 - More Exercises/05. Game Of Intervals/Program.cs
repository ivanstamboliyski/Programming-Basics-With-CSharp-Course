using System;

namespace _05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            double points = 0;
            int group0To9 = 0;
            int group10To19 = 0;
            int group20To29 = 0;
            int group30To39 = 0;
            int group40To50 = 0;
            int groupInvalidNums = 0;

            for (int move = 1; move <= moves; move++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= 0 && num <= 9)
                {
                    group0To9++;
                    points += num * 0.20;
                }
                else if (num >= 10 && num <= 19)
                {
                    group10To19++;
                    points += num * 0.30;
                }
                else if (num >= 20 && num <= 29)
                {
                    group20To29++;
                    points += num * 0.40;
                }
                else if (num >= 30 && num <= 39)
                {
                    group30To39++;
                    points += 50;
                }
                else if (num >= 40 && num <= 50)
                {
                    group40To50++;
                    points += 100;
                }
                else
                {
                    groupInvalidNums++;
                    points = points / 2;
                }

            }

            double group0To9Percent = ((group0To9 * 1.0 / moves) * 100);
            double group10To19Percent = ((group10To19 * 1.0 / moves) * 100);
            double group20To29Percent = ((group20To29 * 1.0 / moves) * 100);
            double group30To39Percent = ((group30To39 * 1.0 / moves) * 100);
            double group40To50Percent = ((group40To50 * 1.0 / moves) * 100);
            double groupInvalidNumsPercent = ((groupInvalidNums * 1.0 / moves) * 100);

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {group0To9Percent:f2}%");
            Console.WriteLine($"From 10 to 19: {group10To19Percent:f2}%");
            Console.WriteLine($"From 20 to 29: {group20To29Percent:f2}%");
            Console.WriteLine($"From 30 to 39: {group30To39Percent:f2}%");
            Console.WriteLine($"From 40 to 50: {group40To50Percent:f2}%");
            Console.WriteLine($"Invalid numbers: {groupInvalidNumsPercent:f2}%");

        }
    }
}
