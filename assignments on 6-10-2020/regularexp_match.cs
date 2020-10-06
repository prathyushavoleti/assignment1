using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regularexp_match
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\d+");//creating a regex
            Match match = regex.Match("prathyusha 55 prathyusha");//call a match on regex instance
            if (match.Success)//test for success
            {
                Console.WriteLine("pattern matched:   {0}", match.Value);
            }
            else
                Console.WriteLine("pattern unmatched");
           
            Console.WriteLine();
            Console.WriteLine("example 2");
            Regex example = new Regex(@"\d+");//creating a regex
            Match mch = example.Match("todays tempersture is 45 degrees");//call a match on regex instance
            if (match.Success)//test for success
            {
                Console.WriteLine("pattern matched:   {0}",mch.Value);
            }
            else
                Console.WriteLine("pattern unmatched");

            Console.ReadLine();
        }
    }
}
