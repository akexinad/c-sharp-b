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


            // FILE STATIC METHODS
            // ===================

            File.Copy(@"c:\temp\myfile.jpg", "d:\temp\myfile.txt", true);
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


            

        }
    }
}
