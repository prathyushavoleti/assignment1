using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace createdirectory2
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentdirectory2 = Directory.GetCurrentDirectory();
            Console.WriteLine(currentdirectory2);
            Console.WriteLine(Directory.GetDirectoryRoot(currentdirectory2));//to find current root directory
            var documentpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var directoryname = $@"{documentpath}\practice file";
            DirectoryInfo din = Directory.CreateDirectory(directoryname);
            Console.WriteLine($"complete name of the directory:{ din.FullName},Name:{din.Name},parent:{din.Parent} ");
            Console.ReadLine();
        }
    }
}
