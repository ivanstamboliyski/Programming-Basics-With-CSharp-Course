using System;

namespace _06.WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsCountFirstSector = int.Parse(Console.ReadLine());
            int seatsCountOddRow = int.Parse(Console.ReadLine());

            int seatsCountEvenRow = seatsCountOddRow + 2;
            int totalSeatsCounter = 0;
            char currSeat = 'a';

            for (char sectors = 'A'; sectors <= lastSector; sectors++)
            {
                if (sectors > 'A')
                {
                    rowsCountFirstSector += 1;
                }
                for (int rows = 1; rows <= rowsCountFirstSector; rows++)
                {
                    int seatsCount = seatsCountOddRow;

                    if (rows % 2 == 0)
                    {
                        seatsCount = seatsCountEvenRow;
                    }
   
                    for (int seats = 1; seats <= seatsCount; seats++)
                    {
                        totalSeatsCounter++;
                        Console.WriteLine($"{sectors}{rows}{currSeat} ");
                        currSeat++;
                    }
                    currSeat = 'a';
                }
            }

            Console.WriteLine(totalSeatsCounter);
        }
    }
}
