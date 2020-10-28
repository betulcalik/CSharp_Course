using System;

namespace _6_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            customerManager.City = "Ankara";
            customerManager.Id = 1;
            customerManager.FirstName = "Betul";
            customerManager.LastName = "Calik";

            CustomerManager customer2 = new CustomerManager {
                Id=2, City="İstanbul", FirstName="Pelin", LastName="Dilek"
            };

            Console.WriteLine(customer2.FirstName);

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Console.ReadLine();
        }
    }

    class CustomerManager 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public void Add()
        {
            Console.WriteLine("Customer added");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated");
        }
    }

    class ProductManager 
    {
        public void Add()
        {
            Console.WriteLine("Product added");
        }

        public void Update()
        {
            Console.WriteLine("Product updated");
        }
    }
}
