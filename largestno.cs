using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestno
{
    class Program
    {
        public static void Main(string[] args)
        {

             
                Console.WriteLine("Largest number in the given array is " + largest());
            Console.ReadLine();
        }
        static int[] arr = { 2, 29, 38, 89, 54 };
       
         public static int largest()
            {
            int i; 
                int max = arr[0];   
                for (i = 1; i < arr.Length; i++)
                    if (arr[i] > max)
                        max = arr[i];
                return max;
            }
        
    }
}
