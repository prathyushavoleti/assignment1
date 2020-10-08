using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_action_predi
{
    //declaring a delegate
    public delegate int addnumsDelegate(int a, int b, int c);
    public delegate double mulnumsDelegate(int a, double b);
    public delegate void squareDelegate(float a);
    public delegate void displayDelegate(string str);
    public delegate bool checkDelegate(string str);
    public delegate bool chkDelegate(int i);
    class func_action_predi
    {
        static void Main(string[] args)
        {
            //instantiating a delegate using FUNC delegate which returns a value
            Func<int,int,int,int> AD = ( i, j, k) =>   i + j + k;
            int d = AD(2, 3, 4);//invoking the data 
            Console.WriteLine(d);

            Func<int,double,double> MD = ( i, j) => i * j;
             double m = MD(2, 123.4555);
            Console.WriteLine(m);
            //instiating a delegate using action delegate which does not returns a value
            Action<float> SD =  a =>
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
            Action<string> DD = str => Console.WriteLine(str + " " + "good morning");
            DD("hello everyone");
            //instantiating a delegate using predicate delegate returns a boolean value
            Predicate<string> CD = str =>
            {
                if (str.Length == 10)
                    return true;
                else
                    return false;
            };
            bool b = CD("prathyusha");
            Console.WriteLine(b);
            Predicate<int> CD1 = (int i) =>
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
