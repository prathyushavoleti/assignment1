using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_constraints
{
    class ruby<T> where T:IDisposable//we have created generic class with the type parameter and assigned the constraint exception
    {
        public void test1()
        {
            Console.WriteLine("its an example of data constraints with IDisposable");
        }
    }
    class Cplus <T> where T:struct//generic class with parameter struct
    {
        public void test2()
        {
            Console.WriteLine("its an example of data constraints with structure");
        }
    }
    //reference type with parameterized constructor
    class read<V> where V:class,new()//new is a constructor being created
    {
        public void test3()
        {
            Console.WriteLine("its an example of data constraints with class program");
        }
    }
    class generic_constraints
    {
        static void Main(string[] args)
        {
            ruby<DataTable> ruby = new ruby<DataTable>();//to store  data with class ruby
            Cplus<int> java = new Cplus<int>();
            read<generic_constraints> test = new read<generic_constraints>();
            ruby.test1();
            java.test2();
            test.test3();
            Console.ReadLine();
        }
    }
}
