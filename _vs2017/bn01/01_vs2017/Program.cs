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
                Write("user name: ");
                p.user = ReadLine();
            }

            p.pwd = "";
            Write("password: ");
            
            while (p.pwd.Length < PWD_MAX) {
                ReadKey(true);
                p.pwd+="*";
                Write("*");
            }

            ReadKey();
            WriteLine("\nHello, "+p.user+'\n');

            WriteLine($"{default(int)}");
            WriteLine($"{default(bool)}");
            WriteLine($"{default(DateTime)}");

            int? maybenull = null;
            WriteLine("\nmaybenull = "+maybenull.GetValueOrDefault());
            maybenull = 0xff;
            WriteLine("\nmaybenull = "+maybenull.GetValueOrDefault());
            ReadKey();

            maybenull = null;
            var ifnull = maybenull ?? 0xfa;
            Write("\nmaybenull = "+maybenull.GetValueOrDefault());
            WriteLine("\tifnull = "+ifnull);
            ReadKey();

            maybenull = 0xab;
            Write("\nmaybenull = "+maybenull.GetValueOrDefault());
            WriteLine("\tifnull = "+ifnull);
            ReadKey();

            ifnull = maybenull ?? 0xfa;
            Write("\nmaybenull = "+maybenull.GetValueOrDefault());
            WriteLine("\tifnull = "+ifnull);


            ReadKey();
            return;
        }
    }
}