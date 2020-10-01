/*write a program to find first n terms in series*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube_series
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, c;
            Console.WriteLine("enter the value of n");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                c = i * i * i;
                Console.WriteLine("{0}", c);
            }
            Console.ReadLine();


        }
    }
}
