using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, n;
            Console.WriteLine("enter a number");
            n=Convert.ToInt32(Console.ReadLine());
            for (i = n; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write( j);
                }
                for (k = i - 1; k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
