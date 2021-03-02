using System;

namespace _04.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());

            int musalaPeople = 0;
            int monblanPeople = 0;
            int kilimanjaroPeople = 0;
            int k2People = 0;
            int everestPeople = 0;

            for (int group = 1; group <= groupsCount; group++)
            {
                int peopleCountPerGroup = int.Parse(Console.ReadLine());

                if (peopleCountPerGroup <= 5)
                {
                    musalaPeople += peopleCountPerGroup;
                }
                else if (peopleCountPerGroup >= 6 && peopleCountPerGroup <= 12)
                {
                    monblanPeople += peopleCountPerGroup;
                }
                else if (peopleCountPerGroup >= 13 && peopleCountPerGroup <= 25)
                {
                    kilimanjaroPeople += peopleCountPerGroup;
                }
                else if (peopleCountPerGroup >= 26 && peopleCountPerGroup <= 40)
                {
                    k2People += peopleCountPerGroup;
                }
                else
                {
                    everestPeople += peopleCountPerGroup;
                }
            }

            int allPeople = musalaPeople + monblanPeople + kilimanjaroPeople + k2People + everestPeople;

            Console.WriteLine($"{musalaPeople * 1.0 / allPeople * 100:F2}%");
            Console.WriteLine($"{monblanPeople * 1.0 / allPeople * 100:F2}%");
            Console.WriteLine($"{kilimanjaroPeople * 1.0 / allPeople * 100:F2}%");
            Console.WriteLine($"{k2People * 1.0 / allPeople * 100:F2}%");
            Console.WriteLine($"{everestPeople * 1.0 / allPeople * 100:F2}%");
        }
    }
}
