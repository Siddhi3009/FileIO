using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //FileExists();
            //ReadLines();
            //ReadText();
            //CopyFile();
            //Delete();
            Program p = new Program();
            p.ReadFromStramReader();
            p.WriteUsingStreamWriter();
            //SerializationDeserialization serializationAndDeserialization = new SerializationDeserialization();
            //serializationAndDeserialization.BinarySerialization();
            //serializationAndDeserialization.BinaryDeSerialization();
        }

        public static void FileExists()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIODemo\Sample.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine(("File doesn't exists"));
        }
        public static void ReadLines()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIODemo\Sample.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
        public static void ReadText()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIODemo\Sample.txt";
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
        public static void CopyFile()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIODemo\Sample.txt";
            string newPath = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIODemo\SampleCopy.txt";
            if (File.Exists(path))
            {
                File.Copy(path, newPath);
            }
            else
            {
                Console.WriteLine("No file");
            }

        }
        public static void Delete()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIODemo\SampleCopy.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                Console.WriteLine("No file");
            }
        }
        public void ReadFromStramReader()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIODemo\Sample.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    String fileData = "";
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
        public void WriteUsingStreamWriter()
        {
            string path = @"C:\Users\Administrator\Desktop\BridgeLabz Practice\33. File IO Operation\FileIODemo\Sample.txt";
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
