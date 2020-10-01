using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum = 0, temp;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                i = n % 10;
                sum = sum + (i * i * i);
                n = n / 10;
            }
            if (temp==sum)
            {
                Console.WriteLine("the number is an armstrong number");
            }
            else
                Console.WriteLine("the number is not an armstrong number");
            Console.ReadLine();
        }
        
    }
}
