using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[][] jaggedarray = 
            {
                new int[] {1, 2, 3, 4},
                new int[] {11, 34, 67},
                new int[] {89, 23},
                new int[] {0, 45, 78, 53, 99}
            };
            for (i = 0; i < jaggedarray.Length; i++)
            {
                Console.WriteLine("Elements of {0} are", i);
                for (j = 0; j < jaggedarray[i].Length; j++)
                {
                    Console.WriteLine(jaggedarray[i][j]);
                }
            }
            Console.ReadLine();
        }
    }
}
