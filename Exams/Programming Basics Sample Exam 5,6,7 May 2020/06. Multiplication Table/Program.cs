using System;

namespace _06.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            int thirdDigit = inputNum % 10;
            inputNum /= 10;
            int secondDigit = inputNum % 10;
            inputNum /= 10;
            int firstDigit = inputNum;

            for (int third = 1; third <= thirdDigit; third++)
            {
                for (int second = 1; second <= secondDigit; second++)
                {
                    for (int first = 1; first <= firstDigit; first++)
                    {
                        int result = third * second * first;

                        Console.WriteLine($"{third} * {second} * {first} = {result};");
                    }
                }
            }
        }
    }
}
