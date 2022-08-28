﻿using System;
namespace Program7
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Enter a number to be checked:");
                int number = int.Parse(Console.ReadLine());
                bool value = IsPrimeNumber(number);
                if (value)
                    Console.WriteLine("Entered number is a Prime Number");
                else
                    Console.WriteLine("Entered number is not a Prime Number");
                Console.WriteLine("Enter 1 to exit or any other number to continue");
                choice = int.Parse(Console.ReadLine());
            } 
            while (choice != 1);
        }

        static bool IsPrimeNumber(int num)
        {
            int x = 0;
            if (num == 1)
            {
                x = 1;
            }
            for (int i = 2; i <= num / 2; ++i)
            {
                if (num % i == 0)
                {
                    x = 1;
                    break;
                }
            }
            if (x == 0)
            {
                return true;
            }
            return false;
        }
    }
}