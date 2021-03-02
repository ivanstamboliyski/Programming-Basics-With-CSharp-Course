using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());

            double changeInSt = Math.Floor(change * 100);
            int counter = 0;

            while (changeInSt > 0)
            {
                if (changeInSt >= 200)
                {
                    changeInSt = changeInSt - 200;
                    counter++;
                }
                else if (changeInSt >= 100)
                {
                    changeInSt = changeInSt - 100;
                    counter++;
                }
                else if (changeInSt >= 50)
                {
                    changeInSt = changeInSt - 50;
                    counter++;
                }
                else if (changeInSt >= 20)
                {
                    changeInSt = changeInSt - 20;
                    counter++;
                }
                else if (changeInSt >= 10)
                {
                    changeInSt = changeInSt - 10;
                    counter++;
                }
                else if (changeInSt >= 5)
                {
                    changeInSt = changeInSt - 5;
                    counter++;
                }
                else if (changeInSt >= 2)
                {
                    changeInSt = changeInSt - 2;
                    counter++;
                }
                else if (changeInSt >= 1)
                {
                    changeInSt = changeInSt - 1;
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
