using System;

namespace _3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref must be defined. out does not required.
            int number1 = 20;
            int number2 = 40;

            Add();
            var result = Add2(2, 3);
            var result2 = Add3(ref number1, number2);
            var result3 = Add4(out number1, number2);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(number1); //30
            Console.WriteLine(result3);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,3,5));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");    
        }

        static int Add2(int x, int y=10)
        {
            return x + y;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add4(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        // Overloading
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
    }
}
