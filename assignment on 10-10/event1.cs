using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @event
{
    public delegate void dg_OddNumber(); //Declared Delegate    
    class event1
    {
        //This is Subscriber Class
    
            static void Main(string[] args)
            {
                OddNumbers O = new OddNumbers();
            //Event gets binded with delegates or registered with delegate
            O.ev_OddNumber += EventMessage;
                O.Odd();
                Console.ReadLine();
            }
            //Delegates calls this method when event raised.  
            static void EventMessage()
            {
                Console.WriteLine("********Event Executed : This is Odd Number**********");
            }
        }
        //This is Publisher Class
        class OddNumbers
        {
            
            public event dg_OddNumber ev_OddNumber; //Declared Events

            public void Odd()
            {

            //Check if result is odd number then raise event
            
                if  (ev_OddNumber != null)
                {
                    ev_OddNumber(); //Raised Event
                }
            }
        }
    }

