using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regularexp_group
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: the input string.
            string input = "/content/alternate-1.aspx";

            // Part 2: call Regex.Match.
            Match match = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$",
                RegexOptions.IgnoreCase);

            // Part 3: check the Match for Success.
            if (match.Success)
            {
                // Part 4: get the Group value and display it.
                string key = match.Groups[1].Value;
                Console.WriteLine(key);
            }
            Console.ReadLine();
        }
    }
}