using System;

namespace _07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int countFans = int.Parse(Console.ReadLine());

            int fansA = 0;
            int fansB = 0;
            int fansV = 0;
            int fansG = 0;

            for (int i = 1; i <= countFans; i++)
            {
                char sector = char.Parse(Console.ReadLine());

                switch (sector)
                {
                    case 'A':
                        fansA++;
                        break;

                    case 'B':
                        fansB++;
                        break;

                    case 'V':
                        fansV++;
                        break;

                    case 'G':
                        fansG++;
                        break;

                }
            }

            double percentFansA = (fansA * 1.0 / countFans) * 100;
            double percentFansB = (fansB * 1.0 / countFans) * 100;
            double percentFansV = (fansV * 1.0 / countFans) * 100;
            double percentFansG = (fansG * 1.0 / countFans) * 100;

            double percentCountFans = (countFans * 1.0 / stadiumCapacity) * 100;

            Console.WriteLine($"{percentFansA:f2}%");
            Console.WriteLine($"{percentFansB:f2}%");
            Console.WriteLine($"{percentFansV:f2}%");
            Console.WriteLine($"{percentFansG:f2}%");
            Console.WriteLine($"{percentCountFans:f2}%");
        }
    }
}
