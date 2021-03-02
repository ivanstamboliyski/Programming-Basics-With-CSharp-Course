using System;

namespace _02.GreetingsPlusAgeEtc
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string surname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {surname}, a {age}-years old person from {town}.");
        }
    }
}
