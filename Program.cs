﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicateelements
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, k;
            int[] arr = new int[10];
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0;i<=n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("elements entered are");
            for (i = 0; i <= n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("after removing the elements");
            for (i = 0; i <= n; i++)
            {
                for (j = i + 1; j <= n;j++)
                {
                    if (arr[i] == arr[j])
                    {
                        for (k = j; k <= n; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        n--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();

        }
        
    }
}
