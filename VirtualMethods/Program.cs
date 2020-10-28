using System;

namespace _11_VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Sql sql = new Sql();
            sql.Add();

            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }

    class Database 
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class Sql : Database 
    {
        public override void Add()
        {
            Console.WriteLine("Sql added");
            // base.Add();
        }
    }

    class MySql : Database 
    {
        public override void Add()
        {
            Console.WriteLine("Mysql added");
            // base.add();
        }
    }
}
