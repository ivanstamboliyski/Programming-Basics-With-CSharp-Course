using System;

namespace _06.LoopsPart2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";

            while (command != "Stop")
            {
                Console.WriteLine(command);
                command = Console.ReadLine();
            }
        }
    }
}
