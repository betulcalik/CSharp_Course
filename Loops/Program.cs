using System;

namespace _5_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoop();
            WhileLoop();
            DoWhileLoop();
            ForEachLoop();
        }

        private static void ForLoop(){
            for(int i=0; i < 50; i++){
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        private static void WhileLoop(){
            int number = 100;
            while(number>=0){
                Console.WriteLine(number);
                number--;
            }
            Console.ReadLine();
        }

        private static void DoWhileLoop(){
            int number = 10;
            do{
                Console.WriteLine(number);
                number--;
            } while(number >= 0);
            Console.ReadLine();
        }

        private static void ForEachLoop(){
            string[] students = {"Betul", "Alper", "Pelin"};
            foreach (var student in students){
                Console.WriteLine(String.Format("{0} {1} {2}", students[0], students[1], students[2]));
            }
            Console.ReadLine();
        }
    }
}
