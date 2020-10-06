using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace static_regex1
{
    class static_regex1
    {
        static void Main(string[] args)
        {
            string str = "/content/WEBDesign-1.aspx";//input string 
            //this calls the static method specified
            Console.WriteLine(regex1.MatchKey(str));
            Console.ReadLine();
        }
    }
    static class regex1
    {
        static Regex _regex11 = new Regex(@"/content/([a-z0-9\-]+).aspx$");//returns lowercase only with irrespective of stored data ex: input = ABCd ==> output =abcd
        //<summary>
        //this returns the key that is matched within the inputs.
        //<summary>
        static public string MatchKey(string str)
        {
            Match match = _regex11.Match(str.ToLower());
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return null;
            }
        }
    }
}
