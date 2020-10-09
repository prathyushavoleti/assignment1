using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mutex1
{
    class mutex1
    {
        private static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
            {
                Thread obj = new Thread(mutexdemo);
                obj.Name = "Thread " + i;
                obj.Start();
            }
            Console.ReadLine();
        }
        static void mutexdemo()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " enters for processing");

            //Blocks the current thread until the current WaitOne method receives a signal. Wait until it is safe to enter. 

            mutex.WaitOne();
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Processing now");
                Thread.Sleep(2000);
                Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " is Completed its task");


            //Call the ReleaseMutex method to unblock so that other threads that are trying to gain ownership of the mutex.

            mutex.ReleaseMutex();
            
    }
}
}
