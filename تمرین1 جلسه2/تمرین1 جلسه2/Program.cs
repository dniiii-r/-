﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 10 && number % 2 == 0)
        {
            Console.WriteLine("TRUE!");

            Console.ReadKey();
        }
    }
}