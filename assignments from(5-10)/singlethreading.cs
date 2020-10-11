using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace list1
{
    class singlethreading
    {
        public string Thread1(string name)
        {
            return "thread1 started";
        }
        public int Thread2(int i)
        {
            for (i = 0; i < 10; i++)
            {
                if (i ==5)
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
            singlethreading s = new singlethreading();
            string a = s.Thread1("hello");
            Console.WriteLine(a);
            int b= s.Thread2(8);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
