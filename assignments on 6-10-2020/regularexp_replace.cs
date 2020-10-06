using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regularexp_replace
{
    class Program
    {
        static void Main(string[] args)
        {
            //replace 2 or more digit pattern with string
            //create an object
            Regex regex = new Regex(@"\d+");
            string result = regex.Replace("cat 123 456", "bird");
            Console.WriteLine("RESULT:{0}", result);
            Console.WriteLine();
            Console.WriteLine("example 2");
            string n = regex.Replace("hello 123", "world");
            Console.WriteLine("RESULT:{0}", n);

            Console.ReadLine();
        }
    }
}
