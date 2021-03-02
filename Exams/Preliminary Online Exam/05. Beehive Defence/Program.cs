using System;

namespace _05.BeehiveDefence
{
    class Program
    {
        static void Main(string[] args)
        {
            int beesCount = int.Parse(Console.ReadLine());
            int bearHealth = int.Parse(Console.ReadLine());
            int bearAttack = int.Parse(Console.ReadLine());

            while (bearHealth > 0)
            {
                beesCount -= bearAttack;

                if (beesCount < 100)
                {
                    if (beesCount < 0)
                    {
                        beesCount = 0;
                    }
                    Console.WriteLine($"The bear stole the honey! Bees left {beesCount}.");
                    break;
                }

                bearHealth -= beesCount * 5;
            }

            if (bearHealth <= 0)
            {
                Console.WriteLine($"Beehive won! Bees left {beesCount}.");
            }
        }
    }
}
