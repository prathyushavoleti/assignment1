using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_assignment1
{
    //declaring a delegate
    public delegate int addnumsDelegate(int a, int b, int c);
    public delegate double mulnumsDelegate(int a, double b);
    public delegate void squareDelegate(float a);
    public delegate void displayDelegate(string str);
    public delegate bool checkDelegate(string str);
    public delegate bool chkDelegate(int i);
    class dlegate_assignment
    {
        //methods
        public static int addnums(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double mulnums(int a, double b)
        {
            return a * b;
        }
        public static void squarenums(float a)
        {
            int i, n = 5;
            for (i = 0; i <= n; i++)
            {
                Console.WriteLine(a * i);
            }
            Console.WriteLine("square of the input is");
            Console.WriteLine(a * a);
        }
        public static void display(string str)
        {
            Console.WriteLine( str+ " "+"good morning");
        }
        public static bool check(string str)
        {
            if (str.Length == 10)
               return true;
            else
                return false;
        }
        public static bool check1(int i)
        {
            if (i >= 20)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            //instantiating the delegate
            addnumsDelegate AD = new addnumsDelegate(addnums);
            int d = AD(2, 3, 4);//invoking data
            Console.WriteLine(d);
            mulnumsDelegate MD = new mulnumsDelegate(mulnums);
            double m = MD(2,123.4555);
            Console.WriteLine(m);
            squareDelegate SD = new squareDelegate(squarenums);
            SD(3.142f);
            displayDelegate DD = new displayDelegate(display);
            DD("hello everyone");
            checkDelegate CD = new checkDelegate(check);
            bool b= CD("prathyusha");
            Console.WriteLine(b);
            chkDelegate CD1 = new chkDelegate(check1);
            bool c=CD1(36);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}











