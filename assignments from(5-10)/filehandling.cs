using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace list1
{
    class writeTofile
    {
        public void data()
        {
            StreamWriter sw = new StreamWriter("C:\\prathyusha\\display.txt");//giving the path to write the data into the display file
            Console.WriteLine("Enter what text has to displayed on the file???");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
        }


    }

    class filehandling
    {
        static void Main(string[] args)
        {
            writeTofile wr = new writeTofile();//instantiating the object
            wr.data();
            Console.ReadLine();
            //reading the file from the display file
            FileStream fs = new FileStream("C:\\prathyusha\\display.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
            sr.Close();
            fs.Close();
            Console.ReadLine();
        }
    }
}