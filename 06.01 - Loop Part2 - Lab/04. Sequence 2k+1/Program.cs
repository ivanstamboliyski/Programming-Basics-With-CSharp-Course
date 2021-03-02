using System;

namespace _04.Sequemce2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int k = 1;

            while (k <= input)
            {
                Console.WriteLine(k);
                k = 2 * k + 1;
            }
        }
    }
}
