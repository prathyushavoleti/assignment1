using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace singlethreading_nonstaticreturn
{
    class nonstaticreturn_1thread
    {
        public string Thread1(string name)
        {
            return "thread1 started";
        }
        public int Thread2(int i)
        {
            for ( i = 0; i < 10; i++)
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
        public double Thread4(double length,double width)
        {
            Console.WriteLine("area of a rectangle is");
            return length * width;
        }
        static void Main(string[] args)
        {
            nonstaticreturn_1thread n = new nonstaticreturn_1thread();
            string s = n.Thread1("prathyusha");
            Console.WriteLine(s);
            int j = n.Thread2(5);
            Console.WriteLine(j);
            string a = n.Thread3("hello world");
            Console.WriteLine(a);
            double c = n.Thread4(12.34, 34.54);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
