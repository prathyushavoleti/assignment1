using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericdel1
{
   
            public delegate T mul<T>(T data, T type); // generic delegate

        class genericdel1
        {
            static void Main(string[] args)
            {
                mul<int> MUL = Mul;
                Console.WriteLine(MUL(12, 2));

                mul<string> con = Concat;
                Console.WriteLine(Concat("Amal","Prathyusha"));
            Console.ReadLine();
            }

            public static int Mul(int a, int b)
            {
                return a*b;
            }

            public static string Concat(string str1, string str2)
            {
                return str1 + str2;
            }
        }
    }
    