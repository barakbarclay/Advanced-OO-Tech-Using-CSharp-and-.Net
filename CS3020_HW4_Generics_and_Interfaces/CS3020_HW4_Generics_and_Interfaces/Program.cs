using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS3020_HW4_Generics_and_Interfaces
{
    class Program
    {
        public static GenericCollection<IMedia> collection = new GenericCollection<IMedia>();
        public static int index = 0;
        static void Main(string[] args)
        {
            int menuChoice = 0;
            int libaryChoice = 0;
            int userIndex = 0;
            string[] paths = null;
            string[] fileTypes = null;
            string[] audioTypes = { "*.mp3", "*.wav" };
            string[] videoTypes = { "*.mp4", "*.avi" };
            string[] imageTypes = { "*.png", "*.jpg" };

            while (menuChoice != 8)
            {
                Console.WriteLine("1. Scan for videos");
                Console.WriteLine("2. Scan for audio");
                Console.WriteLine("3. Scan for images");
                Console.WriteLine("4. Scan for all");
                Console.WriteLine("5. Access video library");
                Console.WriteLine("6. Access audio library");
                Console.WriteLine("7. Access image library");
                Console.WriteLine("8. Close program");
                menuChoice = int.Parse(Console.ReadLine());
                if (menuChoice >= 1 && menuChoice <= 4)
                {
                    collection.EmptyList();
                    index = 0;
                }
                    switch (menuChoice)
                {
                    case 1:
                        fileTypes = videoTypes;
                        break;
                    case 2:
                        fileTypes = audioTypes;
                        break;
                    case 3:
                        fileTypes = imageTypes;
                        break;
                    case 4:
                        fileTypes = videoTypes.Union(audioTypes).Union(imageTypes).ToArray();
                        break;
                    case 5:
                        collection.VideoLibrary();
                        break;
                    case 6:
                        collection.AudioLibrary();
                        break;
                    case 7:
                        collection.ImageLibrary();
                        break;
                    case 8:
                        goto CloseProgram;
                    default:
                        break;
                }
                if (menuChoice >= 1 && menuChoice <= 4)
                {
                    GetArrayOfPaths(ref paths);
                    SearchEachPathRecusively(paths, fileTypes);
                }
                else if (menuChoice >= 5 && menuChoice <= 7)
                {
                    while(libaryChoice != 6)
                    {
                        collection.PrintLibary();
                        Console.WriteLine("1. Sort by name");
                        Console.WriteLine("2. Sort by extension");
                        Console.WriteLine("3. Sort by Date last accessed");
                        Console.WriteLine("4. Touch file");
                        Console.WriteLine("5. Remove file");
                        Console.WriteLine("6. Back to main menu");
                        libaryChoice = int.Parse(Console.ReadLine());
                        switch (libaryChoice)
                        {
                            case 1:
                                collection.SortByName();
                                break;
                            case 2:
                                collection.SortByExtension();
                                break;
                            case 3:
                                collection.SortByDateLastAccessed();
                                break;
                            case 4:
                                Console.WriteLine("Enter an index");
                                userIndex = int.Parse(Console.ReadLine());
                                collection.TouchFile(userIndex);
                                break;
                            case 5:
                                Console.WriteLine("Enter an index");
                                userIndex = int.Parse(Console.ReadLine());
                                collection.RemoveFile(userIndex);
                                break;
                            case 6:
                                goto BackToMainMenu;
                            default:
                                break;
                        }
                    }
                BackToMainMenu:;
                }
            }
        CloseProgram:;
        }

        static void SearchEachPathRecusively(string[] paths, string[] fileTypes)
        {
            foreach (string path in paths)
            {
                // Seperated top level directory search from the rest to not interfere with recursive search
                FindFilesInCurrentDir(path, fileTypes); // Top level dir call
                FindFilesInDirsWithinPath(path, fileTypes); // All dir's inside top level dir
            }
        }

        static void GetArrayOfPaths(ref string[] paths)
        {
            int numOfPaths = 0;
            Console.WriteLine("Enter number of paths.");
            numOfPaths = int.Parse(Console.ReadLine());
            paths = new string[numOfPaths];
            for (int i = 0; i < numOfPaths; i++)
            {
                Console.WriteLine("Enter path (Ex. C:\\Users\\Barak\\Documents).");
                paths[i] = Console.ReadLine();
            }
        }

        static void FindFilesInCurrentDir(string path, string[] fileTypes)
        {
            foreach (string fileType in fileTypes)
            {
                string[] dirs = Directory.GetFiles(path, fileType); // Gets array of path names with indicated file type
                foreach (string dir in dirs)
                {
                    Console.WriteLine(fileType + " found - " + dir);
                    string fileName = dir.Substring(path.Length + 1); // String with just file name
                    fileName = fileName.Substring(0, fileName.Length - 4); // Removes extension from file name
                    if (fileType == "*.jpg" || fileType == "*.png")
                        collection.Enqueue(index, new ImageClass(dir, fileName, fileType));
                    else if (fileType == "*.mp3" || fileType == "*.wav")
                        collection.Enqueue(index, new AudioClass(dir, fileName, fileType));
                    else if (fileType == "*.mp4" || fileType == "*.avi")
                        collection.Enqueue(index, new VideoClass(dir, fileName, fileType));
                    index++;
                }
            }
        }

        static void FindFilesInDirsWithinPath(string path, string[] fileTypes)
        {
            foreach (DirectoryInfo directory in new DirectoryInfo(path).GetDirectories())
            {
                FindFilesInCurrentDir(directory.FullName, fileTypes); // Searches Current directory
                FindFilesInDirsWithinPath(directory.FullName, fileTypes); // Recursive search
            }
        }
    }
}