using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackint
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> mystack = new Stack<int>();
            mystack.Push(2);
            mystack.Push(4);
            mystack.Push(6);
            mystack.Push(8);
            mystack.Push(10);
            mystack.Push(12);
            mystack.Push(14);
            mystack.Push(16);
            mystack.Push(18);
            mystack.Push(20);
            foreach(int x in mystack)
            {
                Console.WriteLine("elements of mystack are:{0}", x);
            }
            Console.WriteLine(mystack.Contains(8));
            Console.WriteLine(mystack.Contains(22));
            Console.WriteLine("the peek element of the stack is:" + mystack.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", mystack.Count());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the peek element of the stack is:" + mystack.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", mystack.Count());

            foreach (int x in mystack)
            {
                Console.WriteLine("the elements in the stack are{0}",x);
            }
            Console.WriteLine(mystack.Contains(8));
            Console.WriteLine(mystack.Contains(14));
            Console.ReadLine();
        }
    }
}
