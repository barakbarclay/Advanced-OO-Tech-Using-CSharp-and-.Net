using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW3_FileIO_and_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfFileTypes = 0;
            int numOfPaths = 0;
            string[] paths;
            string[] fileTypes;

            Console.WriteLine("Enter number of file types.");
            numOfFileTypes = int.Parse(Console.ReadLine());
            fileTypes = new string[numOfFileTypes];
            for (int i = 0; i < numOfFileTypes; i++)
            {
                Console.WriteLine("Enter file type (Ex. *.jpg).");
                fileTypes[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter number of paths.");
            numOfPaths = int.Parse(Console.ReadLine());
            paths = new string[numOfPaths];
            for (int i = 0; i < numOfPaths; i++)
            {
                Console.WriteLine("Enter path (Ex. C:\\Users\\Barak\\Documents).");
                paths[i] = Console.ReadLine();
            }
            
            foreach (string path in paths)
            {
                FindAndCopyFilesInTopLevelDir(path, fileTypes);
                FindAndCopyFilesInDirsWithinPath(path, fileTypes);
            }
        }

        static void FindAndCopyFilesInDirsWithinPath(string path, string[] fileTypes)
        {
            foreach (DirectoryInfo directory in new DirectoryInfo(path).GetDirectories())
            {
                foreach (string fileType in fileTypes)
                {
                    string[] dirs = Directory.GetFiles(directory.FullName, fileType);
                    foreach (string dir in dirs)
                    {
                        string fileName = dir.Substring(directory.FullName.Length + 1);
                        string newDir = AppDomain.CurrentDomain.BaseDirectory + "FoundFiles\\C\\" + dir.Substring(3);
                        newDir = newDir.Remove(newDir.Length - fileName.Length);
                        Directory.CreateDirectory(newDir);
                        File.Copy(Path.Combine(dir), Path.Combine(newDir, fileName), true);
                    }
                }
                FindAndCopyFilesInDirsWithinPath(directory.FullName, fileTypes);
            }
        }

        static void FindAndCopyFilesInTopLevelDir(string path, string[] fileTypes)
        {
            foreach (string fileType in fileTypes)
            {
                string[] dirs = Directory.GetFiles(path, fileType);
                foreach (string dir in dirs)
                {
                    string fileName = dir.Substring(path.Length + 1);
                    string newDir = AppDomain.CurrentDomain.BaseDirectory + "FoundFiles\\C\\" + dir.Substring(3);
                    newDir = newDir.Remove(newDir.Length - fileName.Length);
                    Directory.CreateDirectory(newDir);
                    File.Copy(Path.Combine(dir), Path.Combine(newDir, fileName), true);
                }
            }
        }
    }
}
