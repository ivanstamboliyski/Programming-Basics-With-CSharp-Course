using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widht = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakeArea = widht * lenght;

            string pieces = Console.ReadLine();
            int sumPieces = 0;

            while (pieces != "STOP")
            {
                sumPieces += int.Parse(pieces);

                if (sumPieces >= cakeArea)
                {
                    break;
                }

                pieces = Console.ReadLine();
            }

            if (pieces == "STOP")
            {
                Console.WriteLine($"{cakeArea - sumPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {sumPieces - cakeArea} pieces more.");
            }
   
	            

        }
    }
}
