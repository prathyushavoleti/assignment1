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
            Console.ReadLine();
        }
    }
}
