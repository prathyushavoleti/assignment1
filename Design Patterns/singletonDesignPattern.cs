using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton1
{
    class Program
    {
        static void Main(string[] args)
        {
            mysingleton obj = mysingleton.Instance;
            obj.check();
            singleton obj1 = singleton.Instance;
            obj1.worked();
            singleton.Instance.valueone = 60.00;
            singleton.Instance.valuetwo = 20.00;
            Console.WriteLine("addition of values is " + singleton.Instance.addition());
            Console.WriteLine("subtraction of values is " + singleton.Instance.subtraction());
            Console.WriteLine("division of values is " + singleton.Instance.division());
            Console.WriteLine("multiplication of values is " + singleton.Instance.multiplication());

            Console.ReadLine();
        }
    }
    public class mysingleton
    {
        private mysingleton() { }
        private static mysingleton instance = null;
        public static mysingleton Instance
        {
            get
            {
                if (instance == null)//if instance found true then SDP will be thread unsafe
                {
                    instance = new mysingleton();


                }
                return instance;
            }
        }

        public void check()
        {
            Console.WriteLine("if the instance been null the singleton design pattern is thread unsafe");
        }
    }
}
public sealed class singleton
{
    //private constructor
    singleton() { }
    private static readonly object find = new object();//find whether any of instance are null
    private static singleton instance = null;
    public static singleton Instance
    {
        get
        {
            lock(find)//lock the empty/null instance,so that it would not execute further.if instance found null that means thread is unsafe.
            { 
            if (instance == null)
            {
                { instance = new singleton(); }
            }
                return instance;
            }
        }
    }
    public double valueone { get; set; }
    public double valuetwo { get; set; }
    public double addition()
    { return valueone + valuetwo; }
    public double subtraction()
    { return valueone - valuetwo; }
    public double division()
    { return valueone/valuetwo; }
    public double multiplication()
    { return valueone*valuetwo; }

    public void worked()
    {
        Console.WriteLine("we have locked the null instance to make sure SDP thread safe.");
    }
}





