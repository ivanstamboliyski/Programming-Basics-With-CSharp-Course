using System;

namespace _08.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());

            int valueOdd = 0;
            int valueEven = 0;
            int diff = 0;

            for (int i = 1; i <= pairs; i++)
            {
                int numOne = int.Parse(Console.ReadLine());
                int numTwo = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    valueOdd = (numOne + numTwo);
                }
                else if (i % 2 == 0)
                {
                    valueEven = (numOne + numTwo);
                }

                if (numOne <= 0 && numTwo <= 0)
                {
                    diff = (valueOdd - valueEven);
                }
                else
                {
                    diff = Math.Abs(valueOdd - valueEven);
                }

            }

            if (diff != 0 && pairs != 1)
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
            else 
            {
                Console.WriteLine($"Yes, value={valueOdd}");
            }
               
            
        }
    }
}
