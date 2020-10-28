using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;
            myDelegate();

            Console.WriteLine("**************");

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("hi");

            Console.WriteLine("**************");

            Operations operations = new Operations();

            MyDelegate3 myDelegate3 = operations.Add;
            var result = myDelegate3(2, 7);
            Console.WriteLine(result);

            Console.WriteLine("****************");

            Func<int, int, int> add = Add;
            Console.WriteLine(add(3, 5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());

            Console.ReadLine();
        }

        static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("send message");
        }

        public void ShowAlert()
        {
            Console.WriteLine("show alert");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Operations
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
