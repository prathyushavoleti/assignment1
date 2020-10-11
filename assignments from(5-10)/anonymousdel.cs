using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list1
{
    public delegate void ADelegate(int i, int j);
    public delegate void sDelegate(string s);
    public delegate void cDelegate(string str);
    class anonymousdel
    {

        static void Main(string[] args)
        {
            //anonymous delegate
            ADelegate add = delegate (int i, int j)
              {
                  Console.WriteLine("the sum of the numbers:  " + (i + j));
              };
            add(2, 3);
            //delegate using lambda expression
            ADelegate a = (int i, int j)=> Console.WriteLine("the sum of the numbers:  " + (i * j));
            a(2, 3);
            //Func delegate
            Func<int, int, int> ad = (i, j) =>  i + j;
           int k= ad(3, 4);
            Console.WriteLine(k);
            //action delegate
            Action<string> ac = s => Console.WriteLine(s);
            ac("hello everyone");
            //predicate delegate
            Predicate<string> CD = str =>
            {
                if (str.Length == 10)
                    return true;
                else
                    return false;
            };
            bool b = CD("prathyusha");
            Console.WriteLine(b);



            Console.ReadLine();
        }
    }
}
