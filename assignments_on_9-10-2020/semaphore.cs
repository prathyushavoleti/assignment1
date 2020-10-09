using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace semaphore1
{
    class semaphore1
    {
        public static Semaphore semaphore = new Semaphore(2, 3);

        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Thread obj = new Thread(smpore)
                {
                    Name = "Thread " + i
                };
               obj.Start(i);
            }
            Console.ReadLine();
        }

        static void smpore(object id)
        {
            Console.WriteLine(Thread.CurrentThread.Name + "  Enter for processing");
            
                //Blocks the current thread until the current WaitHandle receives a signal.   
                semaphore.WaitOne();
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is working");
                Thread.Sleep(5000);
                Console.WriteLine(Thread.CurrentThread.Name + "Exit.");
            
            
                //Release() method to release semaphore  
                semaphore.Release();
            
        }
    }
}

