using System;

namespace _05.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    string alphabet = "abcdefghijklmnopqrstuvwxyz";
                    for (char c = 'a'; c <= alphabet[l - 1]; c++)
                    {
                        for (char d = 'a'; d <= alphabet[l - 1]; d++)
                        {
                            for (int e = 1; e <= n ; e++)
                            {
                                if (e > a && e > b)
                                {
                                    Console.Write($"{a}{b}{c}{d}{e} ");
                                }
                            }
                        }
                    }
                }
            }

          

            
        }
    }
}
