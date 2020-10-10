using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace jointhread2
{
    

    class Lockthread2
    {
        
        
            public void display()
            {
            lock (this)
            {
                Console.WriteLine("csharp is an");

                Thread.Sleep(5000);

                Console.WriteLine("object oriented language");
            }
            }
        
            static void Main(string[] args)
        {
            Lockthread2 obj = new Lockthread2();
            //instantiated the thread with a method reference
            Thread t1=new Thread(obj.display);
            Thread t2 = new Thread(obj.display);
            Thread t3 = new Thread(obj.display);
            Thread t4 = new Thread(obj.display);
            Thread t5 = new Thread(obj.display);
            t1.Start();t2.Start();t3.Start(); t4.Start(); t5.Start();
            Console.ReadLine();
        }
    }
}
