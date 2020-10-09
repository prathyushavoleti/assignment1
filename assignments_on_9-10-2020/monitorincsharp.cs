using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace monitorincsharp
{
    class monitorincsharp
    {
        static readonly object obj = new object();         
            public static void numbers()
            {
            Monitor.Enter(obj);   
                  
                    for (int i = 0; i==5; i++)   
                    {   
                        Thread.Sleep(5000);   
                        Console.Write(i + ",");   
                    }   
                    Console.WriteLine();   
                 
                 
                    Monitor.Exit(obj);   
                  
            }   
       
            static void test()
           {   
                   
                lock (obj)   
                {   
                    Thread.Sleep(3000);   
                   Console.WriteLine(Environment.TickCount);   
                }   
          }   
       
          static void Main(string[] args)
            {   
       
                   
                Thread[] thread = new Thread[3];   
                for (int i = 0; i< 3; i++)   
                {   
                    thread[i] = new Thread(new ThreadStart(numbers));   
                    thread[i].Name = "Child " + i;   
                }   
                foreach (Thread t in thread)   
                    t.Start();   
       
                Console.ReadLine();   
            }   
       }   
    } 

        
