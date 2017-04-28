using System;
using static System.Console;
using System.IO;
using static System.IO.Directory;

namespace Ch10_FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string root = @"D:\000\0csharp\_vs2017\";
            string dir = $"{root}Ch10_Example";

            WriteLine($"{dir} exists? {Exists(dir)}");
            WriteLine($"Creating {dir}");
            CreateDirectory(dir);
            WriteLine($"{dir} exists? {Exists(dir)}");
            WriteLine($"Deleting {dir}");
            Delete(dir);
            WriteLine($"{dir} exists? {Exists(dir)}");

            string textFile = $"{root}Ch10.txt";
            string backupFile = $"{root}Ch10.bak";
            
            WriteLine($"{textFile} exists? {File.Exists(textFile)}");

            StreamWriter textWriter = File.CreateText(textFile);
            textWriter.WriteLine("This is a test string.");
            textWriter.Dispose();
            WriteLine($"{textFile} exists? {File.Exists(textFile)}");

            File.Copy(textFile, backupFile, true);
            WriteLine($"{backupFile} exists? {File.Exists(backupFile)}");

            File.Delete(textFile);
            WriteLine($"{textFile} exists? {File.Exists(textFile)}");

            StreamReader textReader = File.OpenText(backupFile);
            WriteLine(textReader.ReadToEnd());
            textReader.Dispose();

        }
    }
}