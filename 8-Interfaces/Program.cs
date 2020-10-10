using System;

namespace _8_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
        //  CustomerManager customerManager = new CustomerManager();
        //  customerManager.Add(new SqlServerCustomerDal());
        //  customerManager.Add(new OracleCustomerDal());

        // Polymorphism
        ICustomerDal[] customerDals = new ICustomerDal[2]
        {
            new SqlServerCustomerDal(),
            new OracleCustomerDal(),
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
        }
    }
}
