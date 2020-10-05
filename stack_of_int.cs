using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_of_integers
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
            foreach (int x in mystack)
            {
                Console.WriteLine("elements of mystack are:{0}", x);
            }
            Console.WriteLine(mystack.Contains(8));
            Console.WriteLine(mystack.Contains(22));
            Console.WriteLine("the peek element of the stack is:" + mystack.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", mystack.Count());
            Console.WriteLine();
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the peek element of the stack is:" + mystack.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", mystack.Count());
            mystack.Push(22);
            mystack.Push(24);
            Console.WriteLine();


            Console.WriteLine("the count of the elements are:{0}", mystack.Count());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the peek element of the stack is:" + mystack.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", mystack.Count());
            Console.WriteLine();
            mystack.Push(26);
            mystack.Push(28);
            mystack.Push(30);
            mystack.Push(32);
            Console.WriteLine("the count of the elements are:{0}", mystack.Count());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the peek element of the stack is:" + mystack.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", mystack.Count());
            Console.WriteLine();
            mystack.Push(34);
            mystack.Push(36);
            mystack.Push(38);
            Console.WriteLine("the count of the elements are:{0}", mystack.Count());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the peek element of the stack is:" + mystack.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", mystack.Count());
            Console.WriteLine();
            mystack.Push(40);
            mystack.Push(42);
            Console.WriteLine("the count of the elements are:{0}", mystack.Count());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the element after applying pop:" + mystack.Pop());
            Console.WriteLine("the peek element of the stack is:" + mystack.Peek());//to find the peek of my stack
            Console.WriteLine("the count of the elements are:{0}", mystack.Count());

            Console.WriteLine(mystack.Contains(2));
            Console.WriteLine(mystack.Contains(14));
            Console.ReadLine();
        }
    }
}
