using System;

namespace _05.PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldGamesCount = int.Parse(Console.ReadLine());

            int counterHearthstone = 0;
            int counterFornite = 0;
            int counterOverwatch = 0;
            int counterOther = 0;

            for (int game = 1; game <= soldGamesCount; game++)
            {
                string gameName = Console.ReadLine();

                switch (gameName)
                {
                    case "Hearthstone":
                        counterHearthstone++;
                        break;

                    case "Fornite":
                        counterFornite++;
                        break;

                    case "Overwatch":
                        counterOverwatch++;
                        break;

                    default:
                        counterOther++;
                        break;
                }
            }

            Console.WriteLine($"Hearthstone - {counterHearthstone * 1.0 / soldGamesCount * 100:F2}%");
            Console.WriteLine($"Fornite - {counterFornite * 1.0 / soldGamesCount * 100:F2}%");
            Console.WriteLine($"Overwatch - {counterOverwatch * 1.0 / soldGamesCount * 100:F2}%");
            Console.WriteLine($"Others - {counterOther * 1.0 / soldGamesCount * 100:F2}%");
        }
    }
}
