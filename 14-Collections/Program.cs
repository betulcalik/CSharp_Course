using System;
using System.Collections;
using System.Collections.Generic;

namespace _14_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Izmir");
            cities.Add('A');

            foreach(var city in cities) {
                Console.WriteLine(city);
            }

            cities.Add("Istanbul");
            Console.WriteLine(cities[2]);

            List<string> countries = new List<string>();
            countries.Add("Turkey");

            foreach(var country in countries){
                Console.WriteLine(country);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer{Id=1, FirstName="Betul", LastName="Calik"});

            var count = customers.Count;

            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4, FirstName = "Ali"},
                new Customer{Id=5, FirstName = "Veli"} 
            });

            var customer2 = new Customer {
                Id=3, FirstName="Deneme"
            };

            customers.Add(customer2);

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index: {0}", index);

            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("Index: {0}", index2);

            customers.Insert(0, customer2);

            foreach(var customer in customers){
                Console.WriteLine(customer.FirstName);
            }

            customers.RemoveAll(c=>c.FirstName=="Betul");
            Console.WriteLine(customers.Contains(customer2));
            customers.Clear();

            Dictionary<string,string> dictionary = new Dictionary<string, string>();
            dictionary.Add("computer", "bilgisayar");
            dictionary.Add("table", "tablo");

            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary){
                Console.WriteLine(item.Key);
            }

            Console.ReadLine();
        }
    }

    class Customer {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
