using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate2
{
    public delegate void MyDelegate(string msg);
    public delegate void dispDelegate(int i);
    public delegate void disp1Delegate(int i,int j);
    
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = ClassA.MethodA;
            InvokeDelegate(del);

            del = ClassB.MethodB;
            InvokeDelegate(del);

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            InvokeDelegate(del);
            Console.WriteLine();
            Console.WriteLine("example-2 of delegate2");

            display1 d = new display1();
            dispDelegate DD = new dispDelegate(d.disp1);
            DD(3);
            disp1Delegate DD1 = new disp1Delegate(display2.disp2);
            DD1(3, 5);

            DD1 = (int i, int j) => Console.WriteLine("the product by using lambda expression" + (i*j));
            DD1.Invoke(5, 6);






            Console.ReadLine();
        }




        static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
        {
            del("Hello World");
        }
    }

    class ClassA
    {
       public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
    class display1
    {
        public void disp1(int i)
        {
            
            for (i =0; i <= 5; i++)
                Console.WriteLine("the natural numbers to be displayed upto 5 is:" + i);
        }
    }

    class display2
    {
        public static void disp2(int i, int j)
        {
            Console.WriteLine("print the numbers" + i + "   " + j);
        }
    }


}

    
    

