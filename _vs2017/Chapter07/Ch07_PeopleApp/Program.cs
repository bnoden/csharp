using System;
using Packt.CS7;
using static System.Console;

namespace Ch07_PeopleApp
{
    class Program
    {
        static string ren(Person p) {
            return p.Children.Count == 1 ? "child" : "children";
        }
        static void Main(string[] args)
        {
            var phil = new Person { Name = "Uncle Phil" };
            var viv = new Person { Name = "Aunt Viv" };
            var progeny1 = phil.HoldHands(viv);
            
            WriteLine($"{viv.Name} has {viv.Children.Count} {ren(viv)}.");
            WriteLine($"{phil.Name} has {phil.Children.Count} {ren(phil)}.");
            WriteLine($"{phil.Name}'s first child is named \"{phil.Children[0].Name}\".");

        }
    }
}