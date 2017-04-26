using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.CS7
{
    public partial class Person
    {

        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;

        public List<Person> Children = new List<Person>();
        
        // read-only fields
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        // constructors
        public Person() {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }
        public Person(string initName) {
            Name = initName;
            Instantiated = DateTime.Now;
        }

        public void inst() {
            WriteLine($"{Name} was instantiated at {Instantiated:hh:mm:ss} on {Instantiated:dddd, d MMMM yyyy}");
            ReadLine();
            }
        public string GetOrigin(DateTime dt) {
            dt = DateOfBirth;
            return $"{Name} was born on {dt:dddd, d MMMM yyyy}";
        }
        public string GetOrigin(string hp) {
            hp = HomePlanet;
            return $"{Name} comes from {hp}";
        }

        // C# 4/.NET 4.0 System.Tuple type
        public Tuple<string, int> GetFruitCS4() {
            return Tuple.Create("Grapes", 5);
        }
        // C# 7 syntax and new System.ValueTuple type
        public (string, int) GetFruitCS7() {
            return ("Grapes", 5);
        }

        public (string Name, int Number) GetNamedFruit() {
            return (Name: "Grapes", Number: 5);
        }

    }
}
