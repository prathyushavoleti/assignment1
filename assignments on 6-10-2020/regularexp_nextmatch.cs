using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace regularexp_nextmatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "4 and 5";
            //get first match
            Match match = Regex.Match(value, @"\d+");
            if(match.Success)
            {
                Console.WriteLine("pattern matched and the first value is:{0}", match.Value);
            }
            //get second match
            match = match.NextMatch();
            if(match.Success)
            {
                Console.WriteLine("pattern matched and the second value is:{0}", match.Value);
            }

            Console.WriteLine();
            Console.WriteLine("example 2");
            string num = "18 and 20 and 22 ";
            //get first match
            Match mch = Regex.Match(num, @"\d+");
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
            //get the third match
            mch = mch.NextMatch();
            if (mch.Success)
            {
                Console.WriteLine("pattern matched and the third value is:{0}", mch.Value);
            }
            Console.ReadLine();
        }
    }
}
