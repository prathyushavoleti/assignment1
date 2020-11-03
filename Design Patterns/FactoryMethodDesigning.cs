using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorymethoddesigning
{
    class Program
    {
        //client code
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your object type");
            string type = Console.ReadLine();
           I1 obj= createobject.Getobject(type);
            Console.WriteLine(obj.getname());
            Console.WriteLine(obj.getcityname());
            Console.ReadLine();
        }

    }

    class createobject
    {
        public static I1 Getobject(string Object)
        {
            I1 obj = null;
          
            if(Object=="student")
            {
                obj = new student();
            }
            else
            {
                obj = new school();
            }
            return obj;

        }
    }
    interface I1
    {
        string getname();
        string getcityname();
        }
    
    class student:I1     //inheritance
    {
        public string getname()
        {
            return "Voleti Amal Prathyusha";
        }
        public string getcityname()
        {
            return "Voleti Vijaya Saradhi";
        }
    }
    class school:I1
    {
        public string getname()
        {
            return "Fort catholic girls high school";
        }
        public string getcityname()
        {
            return "Visakhapatnam";
        }
    }
}
