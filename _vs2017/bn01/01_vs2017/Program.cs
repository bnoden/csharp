using System;

namespace _01_vs2017
{
    class Program
    {
        private string user {get; set;}
        private string pwd {get; set;}
        const int PWD_MAX = 8;

        static void Main(string[] args)
        {
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
            Console.WriteLine("\nHello, "+p.user);


            Console.ReadKey();
            return;
        }
    }
}