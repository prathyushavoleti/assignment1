using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list1
{
    class stack1
    {
        static void Main(string[] args)
        {
            //stack creation
            Stack<int> st = new Stack<int>();
            //pushing elements into stack
            st.Push(2/2);
            st.Push(4+5);
            st.Push(6 * 5);
            st.Contains(4 + 5);
            foreach(int x in st)
            {
                Console.WriteLine("the elements of the stack are  :{0}", x);
            }
            Console.WriteLine("the peek element in the stack: " + st.Peek());
            Console.WriteLine("the elements in the stack are: " + st.Count());
            Console.WriteLine("element after pop  " + st.Pop());
            Console.WriteLine("element after pop  " + st.Pop());
            Console.WriteLine("the elements in the stack are: " + st.Count());
            Console.ReadLine();
        }
    }
}
