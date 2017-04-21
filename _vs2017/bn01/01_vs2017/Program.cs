using System;
using System.Linq;
using System.Reflection;

namespace _01_vs2017
{
    class Program
    {
        private string user {get; set;}
        private string pwd {get; set;}
        const int PWD_MAX = 8;

        static void Main(string[] args)
        {
            System.Xml.XmlReader reader;
            System.Xml.Linq.XElement element;
            System.Net.Http.HttpClient client;

            Program p = new Program();

            Console.Write("user name: ");
            p.user = Console.ReadLine();
            p.pwd = "";
            Console.Write("password: ");
            
            while ((p.pwd).Length <= PWD_MAX) {
                Console.ReadKey(true);
                p.pwd+="*";
                Console.Write("*");
            }

            Console.ReadKey();
            Console.WriteLine("\nHello, "+p.user+'\n');

            foreach (var r in Assembly.GetEntryAssembly()
                .GetReferencedAssemblies()) {
                var a = Assembly.Load(new AssemblyName(r.FullName));
                int methodCount = 0;
                foreach (var t in a.DefinedTypes) {
                    methodCount+=t.GetMethods().Count();
                }
                Console.WriteLine($"{a.DefinedTypes.Count():N0} types " +
                    $"with {methodCount:N0} methods in {r.Name} assembly.");
            }


            Console.ReadKey();
            return;
        }
    }
}