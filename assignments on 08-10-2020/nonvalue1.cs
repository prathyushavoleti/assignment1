using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_methodnonvalue
{
    public delegate void numsDelegate(int i, int j);
    public delegate void wishDelegate(string msg);
    class nonvalue
    {
        static void Main(string[] args)
        {
            numsDelegate ND = new numsDelegate(addnums);
            numsDelegate ND1 = new numsDelegate(mulnums);
            wishDelegate WD = new wishDelegate(wishes);
            wishDelegate WD1 = new wishDelegate(greetings);
           
            ND.Invoke(2, 3);
            ND1.Invoke(5, 6);
            WD("hi");
            WD1("birth");
            Console.ReadLine();

        }
        public static void addnums(int i, int j)
        {
            Console.WriteLine(i + j);
        }
        public static void mulnums(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void wishes(string msg)
        {
            Console.WriteLine("hello good morning");
        }
        public static void greetings(string s)
        {
            Console.WriteLine("happy"+" "+s+"day");
        }


    }
}
