using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("c# lists");
            //create an object for list
            
            //<DataType variable name=new List<datatype>
            var numbers = new List<int>();
            //inserting elements to list
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);
            numbers.Add(12);
            Console.WriteLine("list created");
            foreach (var x in numbers)
            {
                
                Console.WriteLine("the elements of the list are:" + x);
                
            }
            Console.WriteLine();
            Console.WriteLine("the first element is " + " " + numbers[0]);
            Console.WriteLine("the second element is " + " " + numbers[1]);
            Console.WriteLine("the third element is " + " " + numbers[2]);
            Console.WriteLine("the fourth element is " + " " + numbers[3]);
            Console.WriteLine("the fifth element is " + " " + numbers[4]);
            Console.WriteLine("the sixth element is " + " " + numbers[5]);
            Console.WriteLine();
            Console.WriteLine(numbers.Remove(6));//removing elements from list
            //another way of creating a list
            var number = new List<int>() { 1, 2, 3, 4 };
            foreach (var i in number)
            {
                Console.WriteLine("list created by using another way:   {0}", i);
            }
            Console.WriteLine();
            //accessing the list elements by its index
            Console.WriteLine("the first element is "+ " "+number[0]);
            Console.WriteLine("the second element is " + " " + number[1]);
            Console.WriteLine("the third element is " + " " + number[2]);
            Console.WriteLine("the fourth element is " + " " + number[3]);
            Console.WriteLine();
            //index out of bound if we give an index overflow range values
            //insert(position/index,value)//keeps two arguements to be passed int the method
            number.Insert(4, 5);
            Console.WriteLine("the fifth element inserted using insert method and the element is:" + number[4]);
            Console.WriteLine();
            //contains() returns a bool value
            Console.WriteLine(number.Contains(1));
            Console.WriteLine(number.Contains(20));
            Console.WriteLine(number.Contains(14));
            Console.WriteLine(number.Contains(8));
            Console.ReadLine();
        }
    }
}
