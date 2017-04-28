using System;
using System.Linq;
using static System.Console;

namespace Ch09_LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] {"Pam", "Michael", "Jim", "Dwight", "Angela",
                "Kevin", "Toby", "Creed"};

            var query = names
                .Where(name => name.Length>4)
                .OrderBy(name => name.Length)
                .ThenBy(name => name);
            foreach (var item in query) { WriteLine(item); }
        }
    }
}