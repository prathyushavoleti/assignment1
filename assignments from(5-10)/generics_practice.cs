using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list1
{
    class generics<T>//class should contain type parameter
    {
        T data;//parameter declared
        //create a method for class example
        public generics(T type)//type is assigned to type parameter

        {
            this.data = type;
        }
        public void write()
        {
            Console.WriteLine("the value passed to the initializer is:" + this.data);
        }
    }

    class generics_practice
    {
        //driver method
        static void Main(string[] args)
        {
            //use the generic type example with an integer or a string type parameter
            //instantiating the class example
            generics<int> a = new generics<int>(199);
            generics<string> b = new generics<string>("sravani");


            //invoking the method
           a.write();
           b.write();
           Console.ReadLine();
        }

    }
}
