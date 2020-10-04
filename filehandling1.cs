using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling1
{
    class writeTofile
    {
        public void data()
        {
            StreamWriter sw = new StreamWriter("C:\\prathyusha\\sample.txt");
            Console.WriteLine("Enter what text has to displayed on the file???");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            writeTofile wr = new writeTofile();
            wr.data();
            Console.ReadKey();
            FileStream fs = new FileStream("C:\\prathyusha\\sample.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
            sr.Close();
            fs.Close();
            Console.ReadLine();
        }
    }
}
