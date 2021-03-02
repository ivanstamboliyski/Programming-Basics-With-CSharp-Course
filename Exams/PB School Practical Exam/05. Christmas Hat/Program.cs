using System;

namespace _05.ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstSymbol = 1;
            int spaces = n * 2;

            if (n % 2 != 0)
            {
                while (firstSymbol <= n - 2)
                {
                    Console.Write(new string(' ', spaces));
                    Console.WriteLine(new string('#', firstSymbol));
                    spaces--;
                    firstSymbol += 2;
                }

                spaces += 2;
                firstSymbol -= 4;

                while (firstSymbol > 0)
                {
                    Console.Write(new string(' ', spaces));
                    Console.WriteLine(new string('#', firstSymbol));
                    spaces++;
                    firstSymbol -= 2;
                }
            }
            else
            {
                while (firstSymbol <= n - 1)
                {
                    Console.Write(new string(' ', spaces));
                    Console.WriteLine(new string('#', firstSymbol));
                    spaces--;
                    firstSymbol += 2;
                }

                spaces += 2;
                firstSymbol -= 4;

                while (firstSymbol > 0)
                {
                    Console.Write(new string(' ', spaces));
                    Console.WriteLine(new string('#', firstSymbol));
                    spaces++;
                    firstSymbol -= 2;
                }
            }

            int bodySymbol = 1;
            spaces = n * 2 - 1;

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', spaces));
                Console.Write('*');
                Console.Write(new string('~', bodySymbol));
                Console.WriteLine('*');
                bodySymbol += 2;
                spaces -= 2;
            }

            for (int row = 1; row <= n; row++)
            {
                Console.Write('*');
                Console.Write(new string('~', bodySymbol));
                Console.WriteLine('*');
                bodySymbol += 2;
            }

            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine(new string('#', n * 4 + 2));
            }
        }
    }
}
