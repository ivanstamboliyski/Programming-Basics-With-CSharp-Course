using System;

namespace _04.EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsCountFirstPlayer = int.Parse(Console.ReadLine());
            int eggsCountSecondPlayer = int.Parse(Console.ReadLine());

            string winner = Console.ReadLine();

            while (winner != "End of battle")
            {
                if (winner == "one")
                {
                    eggsCountSecondPlayer -= 1;
                    if (eggsCountSecondPlayer == 0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {eggsCountFirstPlayer} eggs left.");
                        break;
                    }
                }
                else if (winner == "two")
                {
                    eggsCountFirstPlayer -= 1;
                    if (eggsCountFirstPlayer == 0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {eggsCountSecondPlayer} eggs left.");
                        break;
                    }
                }
                winner = Console.ReadLine();
            }

            if (winner == "End of battle")
            {
                Console.WriteLine($"Player one has {eggsCountFirstPlayer} eggs left.");
                Console.WriteLine($"Player two has {eggsCountSecondPlayer} eggs left.");
            }

            


        }
    }
}
