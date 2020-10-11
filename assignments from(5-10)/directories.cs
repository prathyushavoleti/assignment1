using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list1
{
    class directories
    {
        static void Main(string[] args)
        {
            var currentdirectory1 = Directory.GetCurrentDirectory();
            Console.WriteLine(currentdirectory1);
            Console.WriteLine(Directory.GetDirectoryRoot(currentdirectory1));//to find current root directory
            var documentpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var dirname = $@"{documentpath}\directory.txt";
            DirectoryInfo din = Directory.CreateDirectory(dirname);
            Console.WriteLine($"complete name of the directory:{ din.FullName},Name:{din.Name},parent:{din.Parent} ");
            Console.ReadLine();
        }
    }
}
