using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.CS7
{
    public class Person
    {

        // fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        // methods
        public void WriteToConsole() {
            WriteLine($"{Name} was born on {DateOfBirth:dddd, d MMMM yyyy}");
        }
        public Person HoldHands(Person partner) {
            var progeny = new Person { Name = $"Fresh baby of {Name} and {partner.Name}" };
            Children.Add(progeny);
            partner.Children.Add(progeny);
            return progeny;
        }

    }
}
