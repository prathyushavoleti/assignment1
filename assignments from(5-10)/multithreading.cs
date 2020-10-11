using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace list1
{
    class multithreading
    {
        public string Thread1(string name)
        {
            return "thread1 started";
        }
        public int Thread2(int i)
        {
            for (i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("the thread2 is sleeping");

                    Thread.Sleep(2000);
                }
                Console.WriteLine("the thread is at the position :" + i);
            }
            return i;
        }
        static void Main(string[] args)
        {
            multithreading m = new multithreading();


            //one main thread and 2 child threads
            Thread T1 = new Thread(delegate ()
            {
                Console.WriteLine(m.Thread1("hello"));
            });
            //create the child threads wrt to methods involved
            Thread T2 = new Thread(delegate ()
            {
                Console.WriteLine(m.Thread2(8));
            });
            T1.Start();T2.Start();
            Console.ReadLine();
        }
   
    }
}
