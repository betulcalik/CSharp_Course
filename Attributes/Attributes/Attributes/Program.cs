using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Calik", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            
            Console.ReadLine();
        }
    }

    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
