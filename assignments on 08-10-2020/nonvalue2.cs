using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_method2
{
    class nonvalue2
    {
        public delegate void numDelegate(int i, int j);
        public delegate void wishDelegate(string msg);
        static void Main(string[] args)
        {
            numDelegate ND = delegate (int i, int j)
              {
                  Console.WriteLine(i + j);
              };
            ND(2, 3);
            numDelegate ND1 = delegate (int i, int j)
            {
                Console.WriteLine(i * j);
            };
            ND1(5,6);
            wishDelegate WD = delegate (string msg)
            {
                Console.WriteLine("hello" + " " + msg + " " + "morning");
            };
            WD.Invoke("good");
            wishDelegate WD1 = delegate (string msg)
            {
                Console.WriteLine("happy" + " " + msg + "day");
            };
            WD1.Invoke("birthday");
            Console.ReadLine();
        }
    }
}
