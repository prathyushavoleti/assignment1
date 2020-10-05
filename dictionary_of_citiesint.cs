using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_of_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "banglore");
            dict.Add(2, "mumbai");
            dict.Add(3, "pune");
            dict.Add(4, "hyderabad");
            dict.Add(5, "chennai");
            dict.Add(6, "delhi");
            dict[7] = "kolkata";
            dict[8] = "ahmedabad";
            dict[9] = "noida";
            dict[10] = "gurgaon";
            dict[11] = "tiuvanantapuram";
            foreach (KeyValuePair<int, string> x in dict)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.WriteLine();
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(1));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(2));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(3));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(4));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(5));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(6));
            foreach (KeyValuePair<int, string> x in dict)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());
            Console.WriteLine();
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(7));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(8));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(9));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(10));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(11));
            foreach (KeyValuePair<int, string> x in dict)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());
            //again add the elements to the dictionary
            dict.Add(1, "banglore");
            dict.Add(2, "mumbai");
            dict.Add(3, "pune");
            dict.Add(4, "hyderabad");
            dict.Add(5, "chennai");
            dict.Add(6, "delhi");
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());

            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(1));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(2));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(3));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(4));

            foreach (KeyValuePair<int, string> x in dict)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());
            Console.WriteLine();
            dict[7] = "kolkata";
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());

            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(5));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(6));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(7));

            foreach (KeyValuePair<int, string> x in dict)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());
            Console.WriteLine();
            dict[8] = "ahmedabad";
            dict[9] = "noida";
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());

            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(8));
            Console.WriteLine("elements left in the dictionary after removed" + dict.Remove(9));

            foreach(KeyValuePair<int, string> x in dict)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.WriteLine("the elements in the dictionay are:" + dict.Count());
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
