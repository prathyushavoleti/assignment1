using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_of_integers
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
            foreach (int x in myqueue)
            {
                Console.WriteLine("elements of myqueue are:{0}", x);
            }
            Console.WriteLine(myqueue.Contains(8));
            Console.WriteLine(myqueue.Contains(22));
            Console.WriteLine("the peek element of the stack is:" + myqueue.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", myqueue.Count());
            Console.WriteLine();
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the peek element of the stack is:" + myqueue.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", myqueue.Count());
            myqueue.Enqueue(22);
            myqueue.Enqueue(24);
            Console.WriteLine();


            Console.WriteLine("the count of the elements are:{0}", myqueue.Count());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the peek element of the stack is:" + myqueue.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", myqueue.Count());
            Console.WriteLine();
            myqueue.Enqueue(26);
            myqueue.Enqueue(28);
            myqueue.Enqueue(30);
            myqueue.Enqueue(32);
            Console.WriteLine("the count of the elements are:{0}", myqueue.Count());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the peek element of the stack is:" + myqueue.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", myqueue.Count());
            Console.WriteLine();
            myqueue.Enqueue(34);
            myqueue.Enqueue(36);
            myqueue.Enqueue(38);
            Console.WriteLine("the count of the elements are:{0}", myqueue.Count());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the peek element of the stack is:" + myqueue.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", myqueue.Count());
            Console.WriteLine();
            myqueue.Enqueue(40);
            myqueue.Enqueue(42);
            Console.WriteLine("the count of the elements are:{0}", myqueue.Count());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the element after applying pop:" + myqueue.Dequeue());
            Console.WriteLine("the peek element of the stack is:" + myqueue.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", myqueue.Count());

            Console.WriteLine(myqueue.Contains(42));
            Console.WriteLine(myqueue.Contains(14));
            Console.ReadLine();
        }
    }
}
