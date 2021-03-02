using System;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargoNumbers = int.Parse(Console.ReadLine());

            double sumTones = 0;
            double minibusCargo = 0;
            double truckCargo = 0;
            double trainCargo = 0;

            for (int i = 1; i <= cargoNumbers; i++)
            {
                int cargo = int.Parse(Console.ReadLine());

                sumTones += cargo;

                if (cargo <= 3)
                {
                    minibusCargo += cargo;
                }
                else if (cargo >= 4 && cargo <= 11)
                {
                    truckCargo += cargo;
                }
                else
                {
                    trainCargo += cargo;
                }
            }

            double averagePricePerTone = (minibusCargo * 200 + truckCargo * 175 + trainCargo * 120) / sumTones;

            double minibusCargoInPercent = minibusCargo / sumTones * 100;
            double truckCargoInPercent = truckCargo / sumTones * 100;
            double trainCargoInPercent = trainCargo / sumTones * 100;


            Console.WriteLine($"{averagePricePerTone:F2}");
            Console.WriteLine($"{minibusCargoInPercent:F2}%");
            Console.WriteLine($"{truckCargoInPercent:F2}%");
            Console.WriteLine($"{trainCargoInPercent:F2}%");


        }
    }
}
