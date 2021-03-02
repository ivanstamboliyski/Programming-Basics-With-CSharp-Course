using System;

namespace _05.SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkCapacity = double.Parse(Console.ReadLine());
            string suitcaseVolume = Console.ReadLine();

            int suitcasesCounter = 0;

            while (suitcaseVolume != "End")
            {
                double currVolume = double.Parse(suitcaseVolume);
                suitcasesCounter++;

                if (suitcasesCounter % 3 == 0)
                {
                    currVolume *= 1.10;
                }
                trunkCapacity -= currVolume;
                if (trunkCapacity < 0)
                {
                    Console.WriteLine("No more space!");
                    suitcasesCounter--;
                    break;
                }
                suitcaseVolume = Console.ReadLine();
            }

            if (suitcaseVolume == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {suitcasesCounter} suitcases loaded.");


        }
    }
}
