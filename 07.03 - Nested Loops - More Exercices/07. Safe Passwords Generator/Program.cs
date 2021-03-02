using System;

namespace _07.SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int maxCountPass = int.Parse(Console.ReadLine());

            int passCounter = 0;
            bool hasToEnd = false;

            for (char symbol1 = (char)35; symbol1 <= (char)55; symbol1++)
            {
                for (char symbol2 = (char)64; symbol2 <= (char)96; symbol2++)
                {
                    for (int symbol3 = 1; symbol3 <= numA; symbol3++)
                    {
                        for (int symbol4 = 1; symbol4 <= numB; symbol4++)
                        {
                            Console.Write($"{symbol1}{symbol2}{symbol3}{symbol4}{symbol2}{symbol1}|");
                            passCounter++;
                            symbol1++;
                            symbol2++;
                           
                            if (symbol1 > 55)
                            {
                                symbol1 = (char)35;
                            }
                            if (symbol2 > 96)
                            {
                                symbol2 = (char)64;
                            }

                            if ((passCounter == maxCountPass) || (numA + numB == symbol3 + symbol4))
                            {
                                hasToEnd = true;
                                break;
                            }
                        }
                        if (hasToEnd)
                        {
                            break;
                        }
                    }
                    if (hasToEnd)
                    {
                        break;
                    }
                }
                if (hasToEnd)
                {
                    break;
                }
            }
        }
    }
}
