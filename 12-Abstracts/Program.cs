using System;

namespace _12_Abstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Delete();
            database.Add();

            Database database2 = new SqlServer();
            database2.Delete();
            database2.Add();
            
            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql");
        }
    }

    class Oracle : Database 
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by oracle");
        }
    }
}
