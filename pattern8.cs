﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(j);
                }
                for (int k = (n - 1); k >= i; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        
            Console.ReadLine();


        }
    }
}
    
