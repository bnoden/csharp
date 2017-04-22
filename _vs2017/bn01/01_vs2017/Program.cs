using System;
using static System.Console;

namespace _01_vs2017
{
    class Program
    {
        private string user {get; set;}
        private string pwd {get; set;}
        const int PWD_MAX = 8;

        static void Main(string[] args)
        {
            var p = new Program();
            p.user = "";
            while (p.user.Length < 1) {
                Console.Write("user name: ");
                p.user = Console.ReadLine();
            }

            p.pwd = "";
            Console.Write("password: ");
            
            while (p.pwd.Length < PWD_MAX) {
                Console.ReadKey(true);
                p.pwd+="*";
                Console.Write("*");
            }

            Console.ReadKey();
            Console.WriteLine("\nHello, "+p.user+'\n');

            Console.WriteLine($"{default(int)}");
            Console.WriteLine($"{default(bool)}");
            Console.WriteLine($"{default(DateTime)}");

            int? maybenull = null;
            Console.WriteLine("\nmaybenull = "+maybenull.GetValueOrDefault());
            maybenull = 0xff;
            Console.WriteLine("\nmaybenull = "+maybenull.GetValueOrDefault());
            Console.ReadKey();
            maybenull = null;
            var ifnull = maybenull ?? 0xfa;
            Console.Write("\nmaybenull = "+maybenull.GetValueOrDefault());
            Console.WriteLine("\tifnull = "+ifnull);
            Console.ReadKey();
            maybenull = 0xab;
            Console.Write("\nmaybenull = "+maybenull.GetValueOrDefault());
            Console.WriteLine("\tifnull = "+ifnull);
            Console.ReadKey();
            ifnull = maybenull ?? 0xfa;
            Console.Write("\nmaybenull = "+maybenull.GetValueOrDefault());
            Console.WriteLine("\tifnull = "+ifnull);


            Console.ReadKey();
            return;
        }
    }
}