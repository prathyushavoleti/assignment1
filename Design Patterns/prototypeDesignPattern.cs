using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{

    public class prototypeDesignPattern
    {
        static void Main(string[] args)
        {
            Database database = new Database
            {
                DatabaseName = "EmployeeDB",
                ServerName = "CloudServer",
                UserName = "John",
                Password = "Doe"
            };
            // Database Object details
            Console.WriteLine($"Original Object# Database Name:  {database.DatabaseName}");
            // Getting the cloned object
            Database clonedDatabase = database.Clone() as Database;
            Console.WriteLine($"Cloned Object# Database Name:  {database.DatabaseName}");
            // Changing cloned object database name
            clonedDatabase.DatabaseName = "SomeOtherDB";
            Console.WriteLine($"Original Object# DatabaseName - {database.DatabaseName}");
            Console.WriteLine($"Cloned Object# DatabaseName - {clonedDatabase.DatabaseName}");
            Console.ReadLine();
        }
    }
    public class Database : ICloneable
    {
      //Public Properties
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ServerName { get; set; }
        
       // Implemented Member
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        
    }
}


