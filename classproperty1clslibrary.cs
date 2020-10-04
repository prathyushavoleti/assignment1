using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classproperty1;

namespace classproperty
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the object for class1
            Class1 c = new Class1();
            //invoke the methods-get and set 
            c.Name = "prathyusha";
            Console.WriteLine(c.Name);
            c.Age = 21;
            Console.WriteLine(c.Age);
            c.City = "visakhapatnam";
            Console.WriteLine(c.City);
            c.Address = "duvvada sector-1,visakhapatnam";
            Console.WriteLine(c.Address);
            c.Mobilenumber = 1234556689;
            Console.WriteLine(c.Mobilenumber);
            c.Email_id = "prathyusha.voleti@gmail.com";
            Console.WriteLine(c.Email_id);
            c.Driving_license = "6f67t7738";
            Console.WriteLine(c.Driving_license);
            c.pan = "DNPPA2313J";
            Console.WriteLine(c.pan);
            c.Aadhar = 432156784563;
            Console.WriteLine(c.Aadhar);
            c.Voter = 234245456;
            Console.WriteLine(c.Voter);
            Console.ReadLine();
        }
    }
}
