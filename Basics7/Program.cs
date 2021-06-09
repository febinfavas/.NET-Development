using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics7
{
    class Program
    {
        static void Main(string[] args)
        {
            //File
            /*
            var path = @"C:\Users\FEBIN FAVAS M\Desktop\aaaaa.txt";
            File.Create(@"C:\Users\FEBIN FAVAS M\Desktop\file.txt");

            File.Copy(@"C:\Users\FEBIN FAVAS M\Desktop\aaaaa.txt", @"C:\Users\FEBIN FAVAS M\Desktop\Febin\aaaaa.txt", true);

            File.Delete(path);

            var content = File.ReadAllText(path);
            Console.WriteLine("content in files are :"+content);

            var fileInfo = new FileInfo(path);
            fileInfo.AppendText();
            fileInfo.Delete();
            */

            //Directory
            /*
            var path = @"C:\Users\FEBIN FAVAS M\Desktop\f1";
            Directory.CreateDirectory(path);

            var files = Directory.GetFiles(@"C:\Users\FEBIN FAVAS M\Desktop","*.*",SearchOption.AllDirectories);
            foreach(var i in files)
                Console.WriteLine(i);

            var directoryInfo = new DirectoryInfo(@"C:\Users\FEBIN FAVAS M\Desktop");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            */


            //Path
            /*
            var path = @"C:\Users\FEBIN FAVAS M\Desktop";
            Console.WriteLine(path.IndexOf('M'));
            Console.WriteLine(Path.GetDirectoryName(path));
            

            */
        }
    }
}
