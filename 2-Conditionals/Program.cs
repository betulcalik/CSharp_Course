﻿using System;

namespace _2_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            
            // If - Else
            if(number == 10) {
                Console.WriteLine("Number is 10");
            } else if(number == 20) {
                Console.WriteLine("Number is 20");
            } else {
                Console.WriteLine("Number is not 10");
            }

            // Single Line If
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            // Switch Case
            switch (number) {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 10");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }

            Console.ReadLine();
        }
    }
}
