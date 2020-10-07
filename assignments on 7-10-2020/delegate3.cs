﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate3
{
    public delegate void MyDelegate(string msg); //declaring a delegate
 
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del1 = ClassA.MethodA;
            MyDelegate del2 = ClassB.MethodB;

            MyDelegate del = del1 + del2; // combines del1 + del2
            del("Hello World");

            MyDelegate del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del += del3; // combines del1 + del2 + del3
            del("Hello World");

            del = del - del2; // removes del2
            del("Hello World");

            del -= del1;// removes del1
           del("Hello World");

           







            Console.ReadLine();
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

   
    
}
