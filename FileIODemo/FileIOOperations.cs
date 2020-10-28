using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIODemo
{
    class FileIOOperations
    {
        /// <summary>
        /// Checks if a file exists or not
        /// </summary>
        public void FileExists()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIO\FileIODemo\Sample.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine(("File doesn't exists"));
        }
        /// <summary>
        /// Reads all lines of a text file as array of strings and displays it on console
        /// </summary>
        public void ReadLines()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIO\FileIODemo\Sample.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                int lengthOfFile = lines.Length;
                Console.WriteLine("Number of lines " + lengthOfFile);
                for (int lineNo = 0; lineNo < lengthOfFile; lineNo++)
                {
                    Console.WriteLine(lines[lineNo]);
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
        /// <summary>
        /// Reads all line of file as a string and displays on console.
        /// </summary>
        public void ReadText()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIO\FileIODemo\Sample.txt";
            if (File.Exists(path))
            {
                string lines = File.ReadAllText(path);
                Console.WriteLine(lines);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
        /// <summary>
        /// Copies contents of one file to other.
        /// </summary>
        public void CopyFile()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIO\FileIODemo\Sample.txt";
            string newPath = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIO\FileIODemo\SampleCopy.txt";
            if (File.Exists(path))
            {
                File.Copy(path, newPath);
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
        /// <summary>
        /// Deletes file reffered by the path from the system.
        /// </summary>
        public void Delete()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIO\FileIODemo\SampleCopy.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
        /// <summary>
        /// Reads contents of a file using StreamReader.
        /// </summary>
        public void ReadFromStramReader()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIO\FileIODemo\Sample.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string fileData = "";
                    while ((fileData = sr.ReadLine()) != null)
                        Console.WriteLine((fileData));
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
        /// <summary>
        /// Appends Contents on a file using a StreamWriter.
        /// </summary>
        public void WriteUsingStreamWriter()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIO\FileIODemo\Sample.txt";
            if (File.Exists(path))
            {
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    streamWriter.WriteLine("Hello World");
                    streamWriter.Close();
                    Console.WriteLine((File.ReadAllText(path)));
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
    }
}
