using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[][] jaggedarray = new int[4][];
            
            jaggedarray[0] = new int[2] { 2, 4 };
            jaggedarray[1] = new int[3] { 3, 6, 9 };
            jaggedarray[2] = new int[4] { 4, 8, 12, 16 };
            jaggedarray[3] = new int[5] { 1, 4, 3, 5,8 };
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
