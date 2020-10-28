using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operations operations = new Operations(2, 3);
            //Console.WriteLine(operations.Add2());
            //Console.WriteLine(operations.Add(3, 4));

            var type = typeof(Operations);

            //Operations operations = (Operations)Activator.CreateInstance(type, 6, 7); //new Operations();
            //Console.WriteLine(operations.Add(4, 5));
            //Console.WriteLine(operations.Add2());

            var instance = Activator.CreateInstance(type, 6, 5);

            MethodInfo methodInfo = instance.GetType().GetMethod("Add2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("******************");

            var methods = type.GetMethods();

            foreach(var method in methods)
            {
                Console.WriteLine("Method name: {0}", method.Name);

                foreach(var parameterInfo in method.GetParameters())
                {
                    Console.WriteLine("Parameter name: {0}", parameterInfo.Name);
                }

                foreach(var attribute in method.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name: {0}", attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    public class Operations
    {
        private int _number1;
        private int _number2;

        public Operations(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public int Add (int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply (int number1, int number2)
        {
            return number1 * number2;
        }

        public int Add2()
        {
            return _number1 + _number2;
        }

        public int Multiply2()
        {
            return _number1 * _number2;
        }
    }
}
