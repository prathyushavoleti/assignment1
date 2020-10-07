﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericdel
{
    
            public delegate T add<T>(T param1, T param2); // generic delegate

        class Program
        {
            static void Main(string[] args)
            {
                add<int> sum = Sum;
                Console.WriteLine(sum(10, 20));

                add<string> con = Concat;
                Console.WriteLine(Concat("Hello ", "World!!"));
            Console.ReadLine();
            }

            public static int Sum(int val1, int val2)
            {
                return val1 + val2;
            }

            public static string Concat(string str1, string str2)
            {
                return str1 + str2;
            }
        }
    }
    

