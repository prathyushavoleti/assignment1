using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reflections_and_attributes
{
    class studentfunction
    {
        private string student;
        public void student_class()
            {
            string name = "prathyusha";
            int age = 21;
            System.Type type = name.GetType();
            System.Type type1 = age.GetType();
            Console.WriteLine(type);
            Console.WriteLine(type1);
            
    }

}
    class Program
    {
        static void Main(string[] args)
        {
            Type T = typeof(int);//initializing the T as typeofstring. (Type==datatype
                                    //use of reflections as below
//i trying to find what sort of data related to t
//it is giving the information about string
            Console.WriteLine("name:" + T.Name);
            Console.WriteLine("Fullname:" + T.FullName);
        
            Console.WriteLine("namespace:" + T.Namespace);
            Console.WriteLine("basetype:" + T.BaseType);
          
            int i = 42;//32bit memory is allocated
            System.Type type = i.GetType();
            System.Console.WriteLine(type);

            //example of uses of reflections to obtain fullname of the loaded assembly
            System.Reflection.Assembly info = typeof(System.Int32).Assembly;
            Console.WriteLine(info);
            studentfunction s = new studentfunction();
            s.student_class();
            Console.ReadLine();
        }
    }
}
