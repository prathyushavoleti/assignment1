﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace jointhread1
{
    class jointhread
    {
        static void Thread1()
        {
            Console.WriteLine("Thread 1 starting");
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Thread1 is executed" + i);
            }
            Console.WriteLine("thread 1 is exiting the run");
        }
        static void Thread2()
        {
            Console.WriteLine("Thread 2 starting");
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Thread2 is executed" + i);
            }
            Console.WriteLine("thread 2 is exiting the run");
        }
        static void Thread3()
        {
            Console.WriteLine("Thread 3 starting");
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Thread3 is executed" + i);
            }
            Console.WriteLine("thread 3 is exiting the run");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("demonstration on JOIN Method in Multhreading");
            Console.WriteLine("Main Thread Started");

            Thread T1 = new Thread(Thread1);
            Thread T2 = new Thread(Thread2);
            Thread T3 = new Thread(Thread3);
            T1.Start(); T2.Start(); T3.Start();
            T1.Join(); T2.Join(); T3.Join();

            Console.WriteLine("main thread is exiting");
            Console.ReadLine();
        }
    }
}
