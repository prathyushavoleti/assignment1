using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascendingorder
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j, a, n;
            int[] arr = new int[10];
            Console.WriteLine("enter the value of n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the array elements");
            for (i = 0; i < n; ++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; ++i)
            {

                for (j = i + 1; j < n; ++j)
                {

                    if (arr[i] > arr[j])
                    {

                        a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                    }
                }
            }

            Console.WriteLine("The numbers arranged in ascending order are:");
            for (i = 0; i < n; ++i)
                Console.WriteLine(arr[i]);
            Console.ReadLine();

        }
    }
}




