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

        // + operator
        public static Person operator+ (Person p1, Person p2) {
            return p1.HoldHands(p2);
        }

        // method with local function
        public int Factorial(int num) {
            if (num < 0) {
                throw new ArgumentException($"{nameof(num)} cannot be less than 0");
            }
            int localFactorial(int localNum) {
                return localNum < 1 ? 1: localNum*localFactorial(localNum-1);
            }
            return localFactorial(num);
        }

    }
}
