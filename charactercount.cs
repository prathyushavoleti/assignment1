using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeatation_of_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("enter the string");
            str = Console.ReadLine();
            while (str.Length > 0)
            {
                Console.Write(str[0]+"----->");
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                        count++;
                }
                Console.WriteLine(count);
                str=str.Replace(str[0].ToString(),string.Empty);
            }
            Console.ReadLine();
        }
    }
}
