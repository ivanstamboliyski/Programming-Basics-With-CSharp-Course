﻿using System;

namespace _09.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours < 24; hours++)
            {
                
                for (int minutes = 0; minutes < 60; minutes++)
                {
                    Console.WriteLine(hours + " : " + minutes);
                }
            }
        }
    }
}
