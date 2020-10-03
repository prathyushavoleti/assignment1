using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using absclass;
using static absclass.cricket;

namespace abstractclass
{
    
    
    class Program 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the target runs");
            int targetRuns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the current over");
            int currentOver = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter current score");
            int currentScore = Convert.ToInt32(Console.ReadLine());
            OneDaycricket O = new OneDaycricket(currentOver, currentScore, targetRuns);

            double cur_runrate = O.calcurrentrunrate();
            double req_runrate = O.requiredrunrate();
            Console.WriteLine("current run rate{0} ", cur_runrate);
            Console.WriteLine(" required run rate is  {0}", req_runrate);
            Console.ReadLine();


        }
    }
}
