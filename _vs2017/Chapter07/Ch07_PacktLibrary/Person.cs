using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.CS7
{
    public partial class Person : IComparable<Person>
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

        // event
        public event EventHandler LimitBreak;

        // field
        public int LimitMeter;
        private const int LIMIT_MAX = 100;
        public bool LimitFull = false;

        // method
        public void Hit(int dmg) {
            LimitFull = LimitMeter >= LIMIT_MAX ? true : false;
            LimitMeter = LimitFull ? LIMIT_MAX : LimitMeter+dmg;
            LimitBreak?.Invoke(this, EventArgs.Empty);
        }
        public void Unload() {
            if (LimitFull) {
                LimitMeter = 0;
            }
        }

        public int CompareTo(Person other) {
            return Name.CompareTo(other.Name);
        }

        // overridden methods
        public override string ToString() {
            return $"{Name} is a {base.ToString()}";
        }
    }
}
