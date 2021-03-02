using System;

namespace _07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());

            double sum = 0;

            if (num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            else
            {
                switch (oper)
                {
                    case '+':
                        sum = num1 + num2;
                        break;
                    case '-':
                        sum = num1 - num2;
                        break;
                    case '*':
                        sum = num1 * num2;
                        break;
                    case '/':
                        sum = (num1 * 1.0) / (num2 * 1.0);
                        break;
                    case '%':
                        sum = num1 % num2;
                        break;
                }

                if (oper == '+' || oper == '-' || oper == '*')
                {
                    double evenOrOdd = sum % 2;
                    if (evenOrOdd == 0)
                    {
                        Console.WriteLine($"{num1} {oper} {num2} = {sum} - even");
                    }
                    else if (evenOrOdd != 0)
                    {
                        Console.WriteLine($"{num1} {oper} {num2} = {sum} - odd");
                    }

                }
                else if (oper == '/')
                {
                    Console.WriteLine($"{num1} / {num2} = {sum:F2}");
                }
                else if (oper == '%')
                {
                    Console.WriteLine($"{num1} % {num2} = {sum}");
                }

            }
        }
    }
}
