﻿using System;
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
            var progeny2 = phil+viv;
            //var progeny3 = phil+progeny1;
            //var progeny4 = progeny2+progeny3;
            
            WriteLine($"{viv.Name} has {viv.Children.Count} {ren(viv)}.");
            WriteLine($"{phil.Name} has {phil.Children.Count} {ren(phil)}.");
            WriteLine($"{phil.Name}'s first child is named \"{phil.Children[0].Name}\".");
            WriteLine($"{phil.Name}'s second child is named \"{phil.Children[1].Name}\".");
            //WriteLine($"{phil.Name}'s third child is named \"{phil.Children[2].Name}\".");

            WriteLine($"5! is {phil.Factorial(5)}");
            WriteLine();

            phil.LimitBreak += Phil_LimitBreak;
            Random r = new Random();
            while(!phil.LimitFull) {
                phil.Hit(r.Next(5, 15));
            }
            WriteLine();

            Person[] people = {
            new Person { Name = "Nebuchadnezzar" },
            new Person { Name = "Penelope" },
            new Person { Name = "Zebu" },
            new Person { Name = "bnoden"}
            };

            WriteLine("Unsorted list:");
            foreach (var person in people) {
                WriteLine($"{person.Name}");
            }

            WriteLine("\nPerson sort:");
            Array.Sort(people);
            foreach (var person in people) {
                WriteLine($"{person.Name}");
            }

            WriteLine("\nPersonComparer sort:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people) {
                WriteLine($"{person.Name}");
            }


        }

        private static void Phil_LimitBreak(object sender, EventArgs e) {
            Person p = (Person)sender;
            if (p.LimitFull) {
                p.Unload();
                WriteLine($"{p.Name} used Jazz Toss!");
            }
            Write($"{p.Name}'s Limit Meter is at {p.LimitMeter}% \t");
            for (int i = 1; i <= p.LimitMeter/5; i++) {
                Write("|");
            }
            WriteLine();
        }


    }
}