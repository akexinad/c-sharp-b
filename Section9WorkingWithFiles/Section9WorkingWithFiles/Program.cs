using System;
using System.IO;

namespace Section9WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * THE SYSTEM.IO NAMESPACE
             * =======================
             * 
             * - The FILE and FILEINFO classes provide methods for creating, copying, deleting, moving, and opening of files.
             * - FILEINFO: Provides INSTANCE methods.
             * - FILE: Provides STATIC methods.
             * 
             * - The difference between the two is security and performance oriented.
             * - When you use the FILE class and check the attributes of certain files, a small security check happens in the background to
             *      check whether or not you have access to said file, so if you checking a lot of files, this can affect the performance of
             *      your machine. Thus its better to create an instance of the FILEINFO class where the security check is only done once.
             * 
             * 
             * - DIRECTORY AND DIRECTORYINFO classes follow the same principles.
             * 
             * 
             */

            var path = @"c:\somefile.txt";

            /*

            // FILE STATIC METHODS
            // ===================

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                // logic
            }

            var contentText = File.ReadAllText(path);
            var contentBinary = File.ReadAllBytes(path);


            // FILEINFO INSTANCE METHODS
            // =========================

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"path/to/where/you/want/to/copy");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                // logic
            }


            */

            Console.Clear();

            // DIRECTORY AND DIRECTORYINFO
            // ===========================

            var path2 = @"c:\Users\cecd304\me\code\udemy";

            Directory.CreateDirectory(path2);

            // This will check this directory and all its subdirectories for pdf files.
            var files = Directory.GetFiles(path2, "*.pdf", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(path2, "*.API", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists(path2);


            // Same as the above but as instances.
            var dirInfo = new DirectoryInfo(path2);
            dirInfo.GetFiles();
            dirInfo.GetDirectories();




            // PATH CLASS
            // ==========

            var path3 = @"C:\Users\cecd304\me\code\udemy\mosh\c-sharp-b\Section1To3\CSharpB.sln";

            var dotIndex = path3.IndexOf('.');
            var extension = path3.Substring(dotIndex);

            // Instead of doing the above, we can just call the GetExtension method.
            var getExtension = Path.GetExtension(path3);

            // Other useful methods.
            Console.WriteLine($"Extension: { getExtension }");
            Console.WriteLine($"File Name: { Path.GetFileName(path3) }");
            Console.WriteLine($"File Name W/O extension: { Path.GetFileNameWithoutExtension(path3) }");
            Console.WriteLine($"File Name: { Path.GetDirectoryName(path3) }");

        }
    }
}
