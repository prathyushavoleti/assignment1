using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queueint
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myqueue = new Queue<int>();
            myqueue.Enqueue(2);
            myqueue.Enqueue(4);
            myqueue.Enqueue(6);
            myqueue.Enqueue(8);
            myqueue.Enqueue(10);
            myqueue.Enqueue(12);
            myqueue.Enqueue(14);
            myqueue.Enqueue(16);
            myqueue.Enqueue(18);
            myqueue.Enqueue(20);
            foreach(int x in myqueue)
            {
                Console.WriteLine("the elements in the queue are:{0}", x);
            }
            
            Console.WriteLine("the peek elements of the queue is:{0}",myqueue.Peek());
            Console.WriteLine("the count in the queue is:{0}",myqueue.Count());
            Console.WriteLine(myqueue.Dequeue());//access the element which is first present
            Console.WriteLine(myqueue.Dequeue());//access the element which is first present
            Console.WriteLine(myqueue.Dequeue());//access the element which is first present
            Console.WriteLine(myqueue.Dequeue());//access the element which is first present
            Console.WriteLine(myqueue.Dequeue());//access the element which is first present
            Console.WriteLine(myqueue.Dequeue());//access the element which is first present
            Console.WriteLine("the peek elements of the queue is:{0}", myqueue.Peek());
            Console.WriteLine("the count in the queue is:{0}", myqueue.Count());

            Console.ReadLine();
        }
    }
}
