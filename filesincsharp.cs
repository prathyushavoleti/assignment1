using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace filesincsharp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var writeText = "hello everyone";  // Create a text string
            File.WriteAllText(@"c://prathyusha//sample.txt", writeText);  // Create a file and write the content of writeText to it
            File.AppendText(@"c://prathyusha//sample.txt");//appends the text

            File.Copy("sample.txt","display1.txt");//copies the content of sample file to display1 file
            File.Create(@"c://prathyusha//filename.txt");//creates a new file
            File.Delete("filename.txt");//deletes the existing file
            File.Exists("filename.txt");//checks for the existence of the file
            File.Replace("sample.txt", "display1.txt","filename.txt");//replaces the source with destination file and backsup in filename
            var readText = File.ReadAllText(@"c://prathyusha//sample.txt");  // Read the contents of the file
            Console.WriteLine(readText);

            Console.ReadLine();
        }
    }
}
