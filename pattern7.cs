﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the value of n");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}",j);
                    
                }
                Console.WriteLine();
            }
            
                Console.ReadLine();
            
        }
    }
}
