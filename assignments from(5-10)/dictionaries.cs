using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list1
{
    class dictionaries
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "prathyusha");
            d.Add(2, "sravani");
            d[3] = "firdos";
            d[4] = "ramya";
            foreach (KeyValuePair<int, string> x in d)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.WriteLine("the number of elements in the dictionaries are:  " + d.Count());

            //to remove the elements
            Console.WriteLine("the element removed is:  " + d.Remove(2));
            foreach (KeyValuePair<int, string> x in d)
            {
                Console.WriteLine("the elements in the dictionay are:" + x.Key + " " + x.Value);
            }
            Console.ReadLine();
        }
    }
}
