using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_delegate
{
    public delegate int addnumsDelegate(int a, int b, int c);
    public delegate double mulnumsDelegate(int a, double b);
    public delegate void squareDelegate(float a);
    public delegate void displayDelegate(string str);
    public delegate bool checkDelegate(string str);
    public delegate bool chkDelegate(int i);
    class anonymous_delegate
    { 
        static void Main(string[] args)
        {
            //instantiating the delegate using anonymous methods
            addnumsDelegate AD = delegate (int i, int j, int k)
            {
                return i+j+k;
            };
            int d = AD(2, 3, 4);//invoking the data
            Console.WriteLine(d);
            mulnumsDelegate MD = delegate (int i, double j)
            {
                return i * j;
            };
            double m = MD(2, 123.4555);
            Console.WriteLine(m);
            squareDelegate SD = delegate (float a)
            {
                int i, n = 5;
                for (i = 0; i <= n; i++)
                {
                    Console.WriteLine(a * i);
                }
                Console.WriteLine("square of the input is");
                Console.WriteLine(a * a);
            };
            SD(3.142f);
            displayDelegate DD = delegate(string str)

            {
                Console.WriteLine(str + " " + "good morning");
            };
            DD("hello everyone");
            checkDelegate CD = delegate (string str)
            {
                if (str.Length == 10)
                    return true;
                else
                    return false;
            };
            bool b = CD("prathyusha");
            Console.WriteLine(b);
            chkDelegate CD1 = delegate (int i)
            {
                if (i >= 20)
                    return true;
                else
                    return false;
            };
            bool c = CD1(36);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
