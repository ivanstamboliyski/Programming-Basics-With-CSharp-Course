using System;

namespace _06.LoopsPart2_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int counterBooks = 0;

            string currBook = Console.ReadLine();

            while (currBook != favoriteBook)
            {
                counterBooks++;

                if (counterBooks >= capacity)
                {
                    break;
                }

                currBook = Console.ReadLine();
            }

            if (currBook == favoriteBook)
            {
                Console.WriteLine($"You checked {counterBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counterBooks} books.");
            }

        }

             

    }
}
