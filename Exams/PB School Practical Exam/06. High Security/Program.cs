using System;

namespace _06.HighSecurity
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin = int.Parse(Console.ReadLine());
            int hashesCount = int.Parse(Console.ReadLine());

            int counter = 0;
            double secretCode = (500 + (pin % 1000)) / 10;

            for (char symbol1 = 'a'; symbol1 <= 'z'; symbol1++)
            {
                for (char symbol2 = 'a'; symbol2 <= 'z'; symbol2++)
                {
                    for (int symbol3 = 0; symbol3 <= 9; symbol3++)
                    {
                        for (char symbol4 = 'a'; symbol4 <= 'z'; symbol4++)
                        {
                            int sum = (symbol1 + symbol2 + symbol3) - symbol4;

                            if (symbol1 != symbol2 && sum == secretCode)           
                            {
                                Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4}");
                                counter++;

                                if (counter == hashesCount)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
