namespace BinaryRepresentationOfText
{
    using System;
    using System.Text;

    public class TextToBinary
    {
        private const int WindowWidth = 80;

        public static void Main()
        {
            Console.WindowWidth = WindowWidth;
            Console.BufferWidth = Console.WindowWidth;

            var decorationLine = new string('-', Console.WindowWidth);
            Console.Write(decorationLine);
            Console.WriteLine("***Converting text to its binary representation***");
            Console.Write(decorationLine);

            Console.Write("Enter the text to code: ");
            var inputText = Console.ReadLine();

            var binaryRepresentation = GetBinaryRepresentation(inputText);

            Console.WriteLine("The binary representation is:");
            Console.WriteLine(binaryRepresentation);
        }
  
        private static StringBuilder GetBinaryRepresentation(string inputText)
        {
            var binaryRepresentation = new StringBuilder();
            for (var i = 0; i < inputText.Length; i++)
            {
                var currentLetterBinary = Convert.ToString(inputText[i], 2);
                binaryRepresentation.AppendFormat("{0} ", currentLetterBinary.PadLeft(8, '0'));
            }

            binaryRepresentation.Length--; // Removing the white space at the end
            
            return binaryRepresentation;
        }
    }
}
