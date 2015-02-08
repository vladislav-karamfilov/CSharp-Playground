namespace LzssAlgorithm
{
    using System;
    using System.Diagnostics;

    internal class LzssDemo
    {
        private const string InputFileNameForEncode = "..\\..\\..\\InputToEncode.txt";
        private const string OutputFileNameForEncode = "..\\..\\..\\EncodedOutput.txt";

        private const string InputFileNameForDecode = "..\\..\\..\\EncodedOutput.txt";
        private const string OutputFileNameForDecode = "..\\..\\..\\DecodedOutput.txt";

        public static void Main()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter \"encode\" to encode file 'InputToEncode.txt' in file 'EncodedOutput.txt'");
                    Console.WriteLine("Enter \"decode\" to decode file 'EncodedOutput.txt' in file 'DecodedOutput.txt'");
                    Console.Write("Enter a command: ");
                    var inputCommand = Console.ReadLine();
                    inputCommand = inputCommand.ToLower();
                    if (inputCommand == "encode")
                    {
                        var watch = new Stopwatch();
                        watch.Start();
                        Lzss.Encode(InputFileNameForEncode, OutputFileNameForEncode);
                        Console.WriteLine("Time elapsed: " + (double) watch.ElapsedMilliseconds/1000 + " s");
                        break;
                    }
                    else if (inputCommand == "decode")
                    {
                        var watch = new Stopwatch();
                        watch.Start();
                        Lzss.Decode(InputFileNameForDecode, OutputFileNameForDecode);
                        Console.WriteLine("Time elapsed: " + (double) watch.ElapsedMilliseconds/1000 + " s");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input command! Try again...");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
