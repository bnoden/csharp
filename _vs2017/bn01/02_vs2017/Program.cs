using System;
using System.IO;
using static System.Console;

namespace _02_vs2017
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"res";

            FileStream file = null;
            StreamWriter writer = null;
            try {
                if (Directory.Exists(path)) {
                    Write("File name: ");
                    string filename = ReadLine();
                    file = File.OpenWrite(Path.Combine(path, filename));
                    writer = new StreamWriter(file);

                    Write("Comment: ");
                    string comment = ReadLine();
                    var date = DateTime.Now;
                    
                    writer.WriteLine("// "+date.ToString()+" ...Success!");
                    writer.WriteLine("// "+comment);
                } else {
                    WriteLine($"{path} could not be found...");
                }
            } catch (Exception ex) {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            } finally {
                if (writer != null) {
                    writer.Dispose();
                    WriteLine("The writer's unmanaged resources were disposed.");
                }
                if (file != null) {
                    file.Dispose();
                    WriteLine("The file's unmanaged resources were disposed.");
                }
            }



            Console.ReadKey();
            return;
        }
    }
}