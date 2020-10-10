using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace performance
{
    class performance
    {
        public static int Thread1(int x, int y)
        {
            long count = 0;
            for (int i = 0; i <= 1000000000; i++)
            {
                count++;

            }
            Console.WriteLine("number of counts" + count);
            return x*y;
            
        }
        public static string Thread2(string str)
        {
            long count = 0;
            for (int i = 0; i <= 1000000000; i++)
            {
                count++;

            }

            Console.WriteLine("number of counts" + count);
            return str;
        }
        static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            
            Thread T1 = new Thread(delegate ()
            {
                Console.WriteLine(Thread1(3,4));
            });//instantiated with the method thread1
            Thread T2 = new Thread(delegate ()
            {
                Console.WriteLine(Thread2("thread 2 exited"));
            });//instantiated with the method thread2
            T1.Start(); T2.Start();
            T1.Join(); T2.Join();
            Console.WriteLine("stopwatch is started");
            s1.Stop();
            Console.WriteLine(s1.ElapsedMilliseconds);
            Console.WriteLine("stopwatch is stopped");
            Console.ReadLine();
        }
    }
}
