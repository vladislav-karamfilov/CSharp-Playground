namespace WordFilesOrganizer
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Microsoft.Office.Interop.Word;

    public class WordFilesOrganizer
    {
        private const string AllFilesPattern = "*.*";
        private const string DocFileExtension = ".doc";
        private const string DocxFileExtension = ".docx";
        private const string SinglePageOutputDirectory = "../../Output/SinglePage";
        private const string MultiplePagesOutputDirectory = "../../Output/MultiplePages";

        public static void Main()
        {
            CreateDirectories(new[] { SinglePageOutputDirectory, MultiplePagesOutputDirectory });

            Console.Write("Enter Word files path: ");
            var wordFilesPath = Console.ReadLine();

            IEnumerable<string> wordFilesPaths;
            try
            {
                wordFilesPaths = GetWordFiles(wordFilesPath);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error getting Word files from path {0}: {1}", wordFilesPath, ex.Message);
                return;
            }

            if (wordFilesPaths.Any())
            {
                try
                {
                    Console.WriteLine("Organizing Word files. Please wait...");

                    OrganizeWordFiles(wordFilesPaths);

                    Console.WriteLine("Word files successfully organized!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error organizing Word files: {0}", ex.Message);
                }
            }
            else
            {
                Console.WriteLine("No Word files found in the provided directory.");
            }
        }

        private static void OrganizeWordFiles(IEnumerable<string> wordFilesPaths)
        {
            var wordApplication = new Application();

            foreach (var wordFilePath in wordFilesPaths)
            {
                var normalizedWordFilePath = Path.GetFullPath(wordFilePath);
                var document = wordApplication.Documents.Open(normalizedWordFilePath);

                var pagesCount = document.ComputeStatistics(WdStatistic.wdStatisticPages);

                var outputDirectory = pagesCount == 1 ? SinglePageOutputDirectory : MultiplePagesOutputDirectory;
                var outputWordFilePath = Path.GetFullPath(string.Format("{0}/{1}", outputDirectory, Path.GetFileName(wordFilePath)));

                document.SaveAs(outputWordFilePath);

                document.Close();
            }

            wordApplication.Quit();
        }

        private static IEnumerable<string> GetWordFiles(string filesPath)
        {
            var wordFiles = Directory.GetFiles(filesPath, AllFilesPattern, SearchOption.AllDirectories)
                .Where(x =>
                    x.EndsWith(DocFileExtension, StringComparison.InvariantCultureIgnoreCase) ||
                    x.EndsWith(DocxFileExtension, StringComparison.InvariantCultureIgnoreCase));

            return wordFiles;
        }

        private static void CreateDirectories(IEnumerable<string> directories)
        {
            foreach (var directory in directories)
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
            }
        }
    }
}
