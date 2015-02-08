namespace Windows1251ToUTF8Converter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class Windows1251ToUtf8Converter
    {
        private const string FilesToConvertPath = @""; // Path to Windows-1251 files
        private const string ConvertedFilesPath = @""; // Path to coverted UTF8 files
        private const string FilesSearchPattern = "*.txt"; // Pattern showing which files will be converted

        internal static void Main()
        {
            DirectoryInfo sourcesDirectory = new DirectoryInfo(FilesToConvertPath);
            Queue<DirectoryInfo> directories = new Queue<DirectoryInfo>();
            directories.Enqueue(sourcesDirectory);
            while (directories.Count != 0)
            {
                DirectoryInfo currentDirectory = directories.Dequeue();

                foreach (FileInfo file in currentDirectory.GetFiles(FilesSearchPattern))
                {
                    ConvertFromWindows1251ToUtf8(file);
                }

                foreach (DirectoryInfo directory in currentDirectory.GetDirectories())
                {
                    directories.Enqueue(directory);
                }
            }

            Console.WriteLine("Conversion done!");
        }

        private static void ConvertFromWindows1251ToUtf8(FileInfo file)
        {
            string destinationDirectory = string.Format("{0}/{1}", ConvertedFilesPath, file.Directory.Name);
            string fileName = file.Name;
            Directory.CreateDirectory(destinationDirectory);
            StreamWriter writer = new StreamWriter(
                string.Format("{0}/{1}", destinationDirectory, fileName),
                false,
                Encoding.UTF8);
            using (writer)
            {
                using (StreamReader reader = new StreamReader(file.FullName, Encoding.GetEncoding(1251)))
                {
                    string content = reader.ReadToEnd();
                    writer.Write(content);
                }
            }
        }
    }
}
