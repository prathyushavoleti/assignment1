using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_of_cities
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<int, string>();
            dict.Add("one", "banglore");
            dict.Add("two", "mumbai");
            dict.Add("three", "pune");
            dict.Add("four", "hyderabad");
            dict.Add("five", "chennai");
            dict.Add("six", "delhi");
            dict["seven"] = "kolkata";
            dict["eight"] = "ahmedabad";
            dict["nine"] = "noida";
            dict["ten"] = "gurgaon";
            dict["eleven"] = "tiuvanantapuram";
            foreach (KeyValuePair<string, string> x in dict)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.WriteLine();
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("one"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("two"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("three"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("four"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("five"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("six"));
            foreach (KeyValuePair<string,string> x in dict)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());
            Console.WriteLine();
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("seven"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("eight"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("nine"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("ten"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("eleven"));
            foreach (KeyValuePair<string, string> x in dict)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
Console.WriteLine("the elements in the dictionay are:" + dict.Count());
            //again add the elements to the dictionary
            dict.Add("one", "banglore");
            dict.Add("two", "mumbai");
            dict.Add("three", "pune");
            dict.Add("four", "hyderabad");
            dict.Add("five", "chennai");
            dict.Add("six", "delhi");
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());
            
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("one"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("two"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("three"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("four"));
            
            foreach (KeyValuePair<string, string> x in dict)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());
            Console.WriteLine();
            dict["seven"] = "kolkata";
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());

            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("five"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("six"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("seven"));
            
            foreach (KeyValuePair<string, string> x in dict)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());
            Console.WriteLine();
            dict["eight"] = "ahmedabad";
            dict["nine"] = "noida";
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());

            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("eight"));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove("nine"));
            
            foreach (KeyValuePair<string, string> x in dict)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
