using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorsNumber = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());

            for (int floor = floorsNumber; floor > 0; floor--)
            {
                for (int rooms = 0; rooms < roomsPerFloor; rooms++)
                {
                    if (floor == floorsNumber)
                    {
                        Console.Write($"L{floor}{rooms} ");
                    }
                    else if (floor % 2 != 0)
                    {
                        Console.Write($"A{floor}{rooms} ");
                    }
                    else
                    {
                        Console.Write($"O{floor}{rooms} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
