using System;

namespace _04.EasterShop_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int startCountEggs = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int soldEggs = 0;
            bool hasToStop = false;

            while (command != "Close" )
            { 
                int eggsCount = int.Parse(Console.ReadLine());

                if (command == "Buy")
                {
                    startCountEggs -= eggsCount;
                    soldEggs += eggsCount;
                    if (startCountEggs < 0)
                    {
                        startCountEggs += eggsCount;
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {startCountEggs}.");
                        hasToStop = true;
                        break; 
                    }
                }
                else if (command == "Fill")
                {
                    startCountEggs += eggsCount;
                }

                command = Console.ReadLine();
            }

            if (!hasToStop)
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }
        }
    }
}
