using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate1
{
    public delegate void MyDelegate(string msg); // declare a delegate
    public delegate void MULDelegate(int i,int j);//declaring a delegate for example 2

    
    class delegate1
    {
        // set target method
        //target method
        static void MethodA(string message)
        {
            Console.WriteLine(message);
        }

        public static void multiplication(int i, int j)
        {
            Console.WriteLine("the product of the values is" + (i * j));
            
        }

        static void Main(string[] args)
        {
            //one way to instantiate a delegate
            MyDelegate del = new MyDelegate(MethodA);
            del("amal");
            // another way to instatiate a delegate
            MyDelegate del1 = MethodA;
            del1("prathyusha");
            // instantiating an element without writing a method ,by setting a lambda expression 
            MyDelegate del2 = (string msg) => Console.WriteLine(msg);
            del2("voleti");

            Console.WriteLine();
            Console.WriteLine("example of delegate");
            delegate1 d = new delegate1();
            //invoking a method as a parameter
            MULDelegate MD = new MULDelegate(multiplication);
            //invoking the values 
            MD.Invoke(2, 3);//one way of invoking
            MD(2, 3);//another way of invoking both returns the same output
            MULDelegate MD1 = multiplication;
            MD1(3, 8);
            MULDelegate MD2 = (int x, int y) => Console.WriteLine(x / y);
            MD2(6, 2);



            Console.ReadLine();
        }
    }
}
