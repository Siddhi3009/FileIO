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
            //File IO Operations
            FileIOOperations fileIOOperations = new FileIOOperations();
            fileIOOperations.FileExists();
            fileIOOperations.ReadLines();
            fileIOOperations.ReadText();
            fileIOOperations.CopyFile();
            fileIOOperations.Delete();
            fileIOOperations.ReadFromStramReader();
            fileIOOperations.WriteUsingStreamWriter();
            //Serialization and Deserialization operations
            SerializationDeserialization serializationAndDeserialization = new SerializationDeserialization();
            serializationAndDeserialization.BinarySerialization();
            serializationAndDeserialization.BinaryDeserialization();
            serializationAndDeserialization.JsonSerialization();
            serializationAndDeserialization.JsonDeSerialization();
            serializationAndDeserialization.XMLSerialize();
            serializationAndDeserialization.XmlDeSerialization();
        }
    }
}
