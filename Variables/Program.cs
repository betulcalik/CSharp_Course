using System;

namespace _1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            long number2 = -65465123156;
            short number3 = -32768;
            byte number4 = 0;
            bool condition = false;
            char character = 'A';
            double number5 = 10.54;
            decimal number6 = 10.4m;
            string day = "Thursday";

            var number7 = 15;

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Condition is {0}", condition);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Character number is {0}", (int)character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("String is {0}", day);
            Console.WriteLine("Day is {0}", Days.Sunday);
            Console.WriteLine("Day number is {0}", (int)Days.Sunday);
            Console.WriteLine("Variable is {0}", number7);
            Console.ReadLine();
        }
    }

    enum Days {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
