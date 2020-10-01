using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upto_n_primenos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, a,n;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("prime numbers within the range are");
            
            for (num = 2; num <= n; num++)
            {
                a = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        a++;
                    }
                }
                if (a == 0 && num != 1)
                    Console.WriteLine(num);

            }

            Console.ReadLine();

        }
    }
}
