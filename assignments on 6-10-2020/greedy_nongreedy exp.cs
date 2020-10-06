using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace greedy_nongreedy
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "/bird/cat/";
            //version1:non-greedy
            var result1 = Regex.Match(str, "^/.*?/");
            if(result1.Success)
            {
                Console.WriteLine("non-greedy:{0}", result1.Value);
            }
            //version 2 greedy
            var result2 = Regex.Match(str, "^/.*/");
            if (result2.Success)
            {
                Console.WriteLine("greedy:{0}", result2.Value);
            }
            Console.WriteLine();
            string s = "/prathyusha/voleti/";
            //version1:non-greedy
            var rslt1 = Regex.Match(s, "^/.*?/");
            if (rslt1.Success)
            {
                Console.WriteLine("non-greedy:{0}", rslt1.Value);
            }
            //version 2 greedy
            var rslt2 = Regex.Match(s, "^/.*/");
            if (rslt2.Success)
            {
                Console.WriteLine("greedy:{0}", rslt2.Value);
            }
            Console.ReadLine();
        }
    }
}
