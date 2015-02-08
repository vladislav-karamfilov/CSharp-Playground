using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

class BinObjFoldersRemover
{
    const string BaseFolder = @"";
    const string BinFolderName = "bin";
    const string ObjFolderName = "obj";
    const string LogFilePath = "../../log.txt";

    static void Main()
    {
        var baseDirectory = new DirectoryInfo(BaseFolder);

        var watch = new Stopwatch();
        watch.Start();

        Console.WriteLine("Deleting all '{0}' and '{1}' directories. Please wait...", BinFolderName, ObjFolderName);

        using (var logsWriter = new StreamWriter(LogFilePath, false, Encoding.UTF8))
        {
            DeleteBinAndObjFolders(baseDirectory, logsWriter);
        }

        Console.WriteLine("All '{0}' and '{1}' directories deleted!", BinFolderName, ObjFolderName);
        Console.WriteLine("Elapsed: {0} sec.", watch.ElapsedMilliseconds / 1000);
    }

    static void DeleteBinAndObjFolders(DirectoryInfo baseDirectory, TextWriter logsWriter)
    {
        var directories = new Queue<DirectoryInfo>();
        directories.Enqueue(baseDirectory);
        while (directories.Count > 0)
        {
            var currentDirectory = directories.Dequeue();
            if (currentDirectory.Name == BinFolderName || currentDirectory.Name == ObjFolderName)
            {
                logsWriter.WriteLine(currentDirectory.FullName);
                currentDirectory.Delete(true);
            }
            else
            {
                foreach (var subdirectory in currentDirectory.GetDirectories())
                {
                    directories.Enqueue(subdirectory);
                }
            }
        }
    }
}