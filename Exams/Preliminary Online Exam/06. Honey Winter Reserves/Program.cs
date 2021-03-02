using System;

namespace _06.HoneyWinterReserves
{
    class Program
    {
        static void Main(string[] args)
        {
            double honeyForWinter = double.Parse(Console.ReadLine());
            string beeName = Console.ReadLine();

            double allBeesHoney = 0;

            while (beeName != "Winter has come")
            {
                double totalHoneyFromBee = 0;

                for (int month = 1; month <= 6; month++)
                {
                    double honeyFromBee = double.Parse(Console.ReadLine());

                    totalHoneyFromBee += honeyFromBee;
                }

                if (totalHoneyFromBee < 0)
                {
                    Console.WriteLine($"{beeName} was banished for gluttony");
                }

                allBeesHoney += totalHoneyFromBee;

                if (allBeesHoney >= honeyForWinter)
                {
                    Console.WriteLine($"Well done! Honey surplus {allBeesHoney - honeyForWinter:F2}.");
                    return;
                }

                beeName = Console.ReadLine();
            }

            Console.WriteLine($"Hard Winter! Honey needed {honeyForWinter - allBeesHoney:F2}.");
        }
    }
}
