using System;

namespace _4_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Betul";
            students[1] = "Alper";
            students[2] = "Pelin";

            string[] students2 = {"Betul", "Alper", "Pelin"};

            string[,] regions = new string[5,3]{
                {"Istanbul", "Izmit", "Balikesir"},
                {"Ankara", "Konya", "Kirikkale"},
                {"Antalya", "Adana", "Mersin"},
                {"Trabzon", "Rize", "Samsun"},
                {"Izmir", "Mugla", "Aydin"},
            };

            for(int i = 0; i <= regions.GetUpperBound(0); i++){
                for(int j = 0; j <= regions.GetUpperBound(1); j++){
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("\n");
            }
            
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
