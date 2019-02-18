using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderTreeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            Path(path);
            //Console.WriteLine(Path(path));
        }
        static void Path(string path)
        {
            foreach (DirectoryInfo directory in new DirectoryInfo(path).GetDirectories())
            {
                //try
                //{
                    foreach (FileInfo file in new DirectoryInfo(directory.FullName).GetFiles())
                    {
                        Console.WriteLine(directory.FullName); // IMPORTANT: directory.FullName is used rather than using and modifying path b/c a new 
                                                               // copy of path isn't made for each iteration of the foreach loop like the recusive method call
                        return;
                    }

                    //path = path + @"\" + directory;
                    Path(directory.FullName);
                    //Path(path);
                //}
                //catch (UnauthorizedAccessException e)
                //{
                    //Console.WriteLine("");
                //}
            }
    
        }
    }
}
