using System;
using System.IO;
using System.Text;

namespace W3
{
    class Program
    {
        static string fileRead = @"input.txt";

        static string fileWrite = @"output.txt";

        static string readString;

        static char CheckChar;

        static int SynCount = 0;

        static string[] TextArr;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            StreamReader reader = new StreamReader(fileRead);
            readString = reader.ReadToEnd();

            for (int i = 0; i < readString.Length; i++)
            {
                CheckChar = readString[i];
                if (CheckChar == '.' || CheckChar == ',' || CheckChar == '!' || CheckChar == '?' ||
                    CheckChar == ':' || CheckChar == ';' || CheckChar == '"' || CheckChar == '(' || CheckChar == ')')
                {
                    SynCount++;
                    Console.WriteLine(SynCount);
                }
            }
            File.AppendAllText(fileWrite, SynCount.ToString() + "\n");

            TextArr = readString.Split(new char[] { ' ', '.', ',' , ';' , '"', ':', '!' , '?', '(', ')' });
            foreach (string word in TextArr)
            {
                if (word.Length % 2 == 0)
                {
                    File.AppendAllText(fileWrite, word.ToString() + "\n");
                    Console.WriteLine(word);
                }
            }
        }
    }
}
