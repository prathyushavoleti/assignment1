using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multithreading_nonstaticreturn
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
                if (i == 4)
                {
                    Console.WriteLine("the thread2 is sleeping");

                    Thread.Sleep(10000);
                }
                Console.WriteLine("the thread is at the position :" + i);
            }
            return i;
        }
        public string Thread3(string str)
        {
            if (str.Length > 5)
            {
                Console.WriteLine("the thread is sleeping");

                Thread.Sleep(5000);
            }
            return "thread3 started";
        }
       
        static void Main(string[] args)
        {
            multithreading m = new multithreading();
            

            //one main thread and 4 child threads
            Thread T1 = new Thread(delegate ()
            {
                Console.WriteLine(m.Thread1("prathyusha"));
            });
//create the child threads wrt to methods involved
            Thread T2 = new Thread(delegate ()
            {
                Console.WriteLine(m.Thread2(5));
            });
            Thread T3 = new Thread(delegate ()
            {
                Console.WriteLine(m.Thread3("thread concept"));
            });
            
            T1.Start(); T2.Start(); T3.Start(); 
            Console.ReadLine();
            

        }
    }
}
