using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mulcastrtrn_prac
{
    public delegate int exampleDelegate();

    class multicastwthrtrn
    {
        static void Main(string[] args)
        {
            
               exampleDelegate ex = new exampleDelegate(add);
                ex += mul;
            // The Value will be 6, returned by the mul(),as it is the last method in the invocation list.

            int Value = ex();
                Console.WriteLine("Returned Value = {0}", Value);
                Console.ReadLine();
            }
            // This method returns 5
            public static int add()
            {
                return 2+3;
            }
            // This method returns 6
            public static int mul()
            {
                return 2*3;
            }
        }
    }
    

