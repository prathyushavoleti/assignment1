using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicastdel_prac
{
    public delegate void RectangleDelete(int Width, int Height);
    public class multicastdel_prac
    {
        public void Area(int Width, int Height)
        {
            Console.WriteLine("Area is {0}", (Width * Height));
        }
        public void Perimeter(int Width, int Height)
        {
            Console.WriteLine("Perimeter is {0}", (2 * (Width + Height)));
        }
        static void Main(string[] args)
        {
            multicastdel_prac rect = new multicastdel_prac();
            RectangleDelete rectDelegate = new RectangleDelete(rect.Area);

            // In this example rectDelegate is a multicast delegate. 
            // we use += operator to combine delegates together and -= operator to remove.
            rectDelegate += rect.Perimeter;
            rectDelegate(5, 10);

            Console.WriteLine();
            rectDelegate(10,5);
            Console.WriteLine();
            //Removing a method from delegate object
            rectDelegate -= rect.Perimeter;
            rectDelegate(10, 5);
            Console.ReadLine();
        }
    }
    
}
