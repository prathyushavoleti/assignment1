using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace deadlock
{
    public class locks
    {
        static readonly object firstLock = new object();
        static readonly object secondLock = new object();
        static void Threads()
        {
            Console.WriteLine("Locking firstLock");
            lock (firstLock)
            {
                Console.WriteLine("Locked firstLock");
                // Wait until  the first thread has grabbed secondLock

                Thread.Sleep(1000);
                Console.WriteLine("Locking secondLock");
                lock (secondLock)
                {
                    Console.WriteLine("Locked secondLock");
                }
                Console.WriteLine("Released secondLock");
            }
            Console.WriteLine("Released firstLock");
        }
        class deadlock
        {
            static void Main(string[] args)
            {


                new Thread(new ThreadStart(Threads)).Start();
                // Wait until  the other thread has grabbed firstLock

                Thread.Sleep(500);
                Console.WriteLine("Locking secondLock");
                lock (secondLock)
                {
                    Console.WriteLine("Locked secondLock");
                    Console.WriteLine("Locking firstLock");
                    lock (firstLock)
                    {
                        Console.WriteLine("Locked firstLock");
                    }
                    Console.WriteLine("Released firstLock");
                }
                Console.WriteLine("Released secondLock");
                Console.ReadLine();
            }
        }
    }
}
