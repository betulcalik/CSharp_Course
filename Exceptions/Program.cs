using System;
using System.Collections.Generic;

namespace _15_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExveptionIntro();
            try {
                Find();
            }
            catch(RecordNotFoundException exception){
                Console.WriteLine(exception.Message);
            }

            HandleException(()=>{
                Find();
            });
        }

        private static void HandleException(Action action){
            try {
                action.Invoke();
            }
            catch ( Exception exception){
                Console.WriteLine(exception.Message);
            }
        }

        private static void ExceptionIntro() {
            try {
                string[] students = new string[3] {"Ali", "Ayse", "Veli"};
                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception){
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception) {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception){
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find(){
            List<string> students = new List<string>{"Ali", "Veli", "Ayse"};
            if(!students.Contains("Ahmet")){
                throw new RecordNotFoundException("Record not found");
            } else {
                Console.WriteLine("Record found");
            }
        }
    }
}
