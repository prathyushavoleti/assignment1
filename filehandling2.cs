using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace filehandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"c://prathyusha//sample");
            Console.WriteLine("Enter the text u wish to write into the document");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            FileStream fs = new FileStream(@"c://prathyusha//sample", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
            sr.Close();
            Console.ReadLine();
            


        }
    }
}
