using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list1
{
    class jagged_array
    {
        static void Main(string[] args)
        { 
            int i, j;
        int[][] jd = new int[3][];

        jd[0] = new int[2] { 3, 8 };
        jd[1] = new int[3] { 1, 5, 9 };
        jd[2] = new int[4] { 3, 2, 7, 10 };
        
            for (i = 0; i<jd.Length; i++)
            {
                Console.WriteLine("Elements of {0} are", i);
                for (j = 0; j<jd[i].Length; j++)
                {
                    Console.WriteLine(jd[i][j]);
                }
            }
            Console.ReadLine();
        }
    }
}
