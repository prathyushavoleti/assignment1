using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace list1
{
    class regular_expressions
    {
        static void Main(string[] args)
        {
           Regex regex = new Regex(@"\Athe");//creating a regex

            Match match = regex.Match("the sun rises in the east");//call a match on regex instance
            if (match.Success)//test for success
            {
                Console.WriteLine("pattern matched:   {0}", match.Value);
            }
            else
                Console.WriteLine("pattern unmatched");
            Console.WriteLine();

            Console.WriteLine("example for ismatch");
            string num = "5678";

            //match the start of a int
            if (Regex.IsMatch(num, "^56"))
            {
                Console.WriteLine("pattern matched at the start");
            }
            //// Match the end of string 
            if (Regex.IsMatch(num, "78$"))
            {
                Console.WriteLine("pattern matched at the end");
            }
            Console.WriteLine();
            Console.WriteLine("example for nextmatch");


            string value = "7 and 8";
            //get first match
            Match mch = Regex.Match(value, @"\d+");
            if (mch.Success)
            {
                Console.WriteLine("pattern matched and the first value is:{0}", mch.Value);
            }
            //get second match
            mch = mch.NextMatch();
            if (mch.Success)
            {
                Console.WriteLine("pattern matched and the second value is:{0}", mch.Value);
            }

            Console.WriteLine();
            Console.WriteLine("example for replace");
            Regex rgx = new Regex(@"\d+");
            string n = rgx.Replace("everyone 123", "hello");
            Console.WriteLine("RESULT:{0}", n);


            Console.ReadLine();
     
        }
    }
}
