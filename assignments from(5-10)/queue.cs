using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list1
{
    class queue
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            for(int i=1;i<=10;i++)
            {
                q.Enqueue(2 * i);
            }
            foreach (int x in q)
            {
                Console.WriteLine("the elements in the queue are:  " + x);
            }
            Console.WriteLine("the elements is contained in the queue : " + q.Contains(10));
            Console.WriteLine("the number of elements in the queue are:  " + q.Count());
            Console.WriteLine("the elements after removing from the queue are: " + q.Dequeue());
            Console.WriteLine("the elements after removing from the queue are: " + q.Dequeue());
            Console.WriteLine("the elements after removing from the queue are: " + q.Dequeue());
            Console.WriteLine("the elements is contained in the queue : " + q.Contains(10));
            Console.WriteLine("the number of elements in the queue are:  " + q.Count());
            Console.ReadLine();
        }
    }
}
