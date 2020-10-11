using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list1
{
    class list1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("c# lists");
            //create an object for list
            var str = new List<string>();
            //inserting elements to list
            str.Add("welcome");
            str.Add("to the");
            str.Add("world of");
            str.Add("technology");
            foreach (var x in str)
            {

                Console.WriteLine("the elements of the list are:" + x);

            }
            str.Count();
            //accessing the elements using index values
            Console.WriteLine();
            Console.WriteLine("the first element is " + " " + str[0]);
            Console.WriteLine("the second element is " + " " + str[1]);
            Console.WriteLine("the third element is " + " " + str[2]);
            Console.WriteLine("the fourth element is " + " " + str[3]);
            Console.WriteLine();
            str.Remove("technology");//remove the element
           
            //contains returns a bool value
            Console.WriteLine(str.Contains("world of"));
            Console.ReadLine();



        }
    }
}
