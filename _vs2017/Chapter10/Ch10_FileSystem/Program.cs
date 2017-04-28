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
            string root = @"D:/000/0csharp/_vs2017/";
            //string dir = $"{root}Ch10_Example";
            string dir = "../Ch10_Example/";

            WriteLine($"{dir} exists? {Exists(dir)}");
            ReadLine();
            WriteLine($"Creating {dir}");
            CreateDirectory(dir);
            ReadLine();
            WriteLine($"{dir} exists? {Exists(dir)}");
            WriteLine($"Deleting {dir}");
            Delete(dir);
            ReadLine();
            WriteLine($"{dir} exists? {Exists(dir)}");
            WriteLine();

            WriteLine($"Creating {dir}");
            CreateDirectory(dir);
            string dirBackup = "../backup/";
            CreateDirectory(dirBackup);

            string textFile = $"{dir}Ch10.txt";
            string backupFile = $"{dirBackup}Ch10.bak";
            
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

            WriteLine($"File name: {Path.GetFileName(textFile)}");
            WriteLine($"File name without extension: " +
                $"{Path.GetFileNameWithoutExtension(textFile)}");
            WriteLine($"File extension: {Path.GetExtension(textFile)}");
            WriteLine($"Random file name: {Path.GetRandomFileName()}");
            WriteLine($"Temporary file name: {Path.GetTempFileName()}");
            WriteLine();

            //string backup = $"{root}Ch10.bak";
            var info = new FileInfo(backupFile);
            WriteLine($"{backupFile} contains {info.Length} bytes.");
            WriteLine($"{backupFile} was last accessed {info.LastAccessTime}");
            WriteLine($"{backupFile} has readonly set to {info.IsReadOnly}");

            Delete(dir);

        }
    }
}