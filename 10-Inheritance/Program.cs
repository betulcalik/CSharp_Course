using System;

namespace _10_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2]
            {
                new Customer{FirstName="Betul"},
                new Student{FirstName="Calik"}
            };

            foreach(var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person 
    {
        public string City { get; set; }
    }

    class Student : Person 
    {
        public string Department { get; set; }
    }
}
