using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regex_parseno
{
    class regex_parseno
    {
        static bool IsValid(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z0-9]*$");
        }

        static void Main(string[] args)
        {
            string input = "Dot Net 100 Perls";
            Match match = Regex.Match(input, @"\d+");
            if (match.Success)
            {
                int.TryParse(match.Value, out int number);
                // Show that we have the numbers.
                Console.WriteLine("NUMBERS: {0}, {1}", number, number + 1);
            }


            Console.WriteLine();
            Console.WriteLine("example-2");
            string str = "today the temperature is 50 degrees";
            Match mch = Regex.Match(str, @"\d+");
            if (mch.Success)
            {
                int.TryParse(mch.Value, out int celcius);
                // Show that we have the temperature
                Console.WriteLine("temperature: {0}, {1}", celcius, celcius + 1);
            }



            Console.WriteLine();
            Console.WriteLine("to find the value,length and index");
            Match m = Regex.Match("123 Axxxxy", @"A.*y");
            if (m.Success)
            {
                Console.WriteLine("Value  = " + m.Value);
                Console.WriteLine("Length = " + m.Length);
                Console.WriteLine("Index  = " + m.Index);
            }


            Console.WriteLine();
            Console.WriteLine("Example-2 to find the length, value and index");
            Match n = Regex.Match("2306 Prathyusha", @"P.*a");
            if (n.Success)
            {
                Console.WriteLine("Value  = " + n.Value);
                Console.WriteLine("Length = " + n.Length);
                Console.WriteLine("Index  = " + n.Index);
            }


            Console.WriteLine();
            Console.WriteLine("example to return boolean value for ismatch method");
            // Test the strings with the IsValid method.
            Console.WriteLine(IsValid("dotnetperls0123"));
            Console.WriteLine(IsValid("DotNetPerls"));
            Console.WriteLine(IsValid("$1.:"));
            // Console.WriteLine(IsValid(null)); // Throws an exception


            Console.WriteLine();
            Console.WriteLine("example for ignorecase ");
            const string value = "TEST";
            // ... This ignores the case of the "TE" characters.
            if (Regex.IsMatch(value, "te..", RegexOptions.IgnoreCase))
            {
                Console.WriteLine(true);
            }


            Console.WriteLine();
            Console.WriteLine("example-2 for ignorecase ");
            const string s = "PRATHYUSHA";
            // ... This ignores the case of the "TE" characters.
            if (Regex.IsMatch(s, "pra.......", RegexOptions.IgnoreCase))
            {
                Console.WriteLine(true);
            }

            Console.WriteLine();
            Console.WriteLine("example for ignorecase ");
            Console.ReadLine();
        }
    }
}
