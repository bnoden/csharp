using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using static System.Console;
using Newtonsoft.Json;

namespace Ch10_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person> {
                new Person(30000M) {
                FirstName = "Alice", LastName = "Smith",
                DateOfBirth = new DateTime(1974, 3, 14) },
            new Person(40000M) { FirstName ="Bob", LastName = "Jones",
                DateOfBirth = new DateTime(1969, 11, 23) },
            new Person(20000M) { FirstName = "Charlie", LastName = "Rose",
                DateOfBirth = new DateTime(1964, 5, 4),
                Children = new HashSet<Person> {
                    new Person(0M) { FirstName = "Sally", LastName = "Rose",
                    DateOfBirth = new DateTime(1990, 7, 12) } } }
            };

            string xmlFilepath = @"../Ch10_People.xml";
            FileStream xmlStream = File.Create(xmlFilepath);

            var xs = new XmlSerializer(typeof(List<Person>));

            xs.Serialize(xmlStream, people);
            xmlStream.Dispose();
            WriteLine($"Written {new FileInfo(xmlFilepath).Length} bytes of XML to {xmlFilepath}");
            WriteLine();

            WriteLine(File.ReadAllText(xmlFilepath));

            FileStream xmlLoad = File.Open(xmlFilepath, FileMode.Open);
            var loadedPeople = (List<Person>)xs.Deserialize(xmlLoad);
            foreach (var item in loadedPeople) {
                WriteLine($"{item.LastName} has {item.Children.Count} children.");
            }
            xmlLoad.Dispose();

            string jsonFilepath = @"../Ch10_People.json";
            StreamWriter jsonStream = File.CreateText(jsonFilepath);
            var jss = new JsonSerializer();

            jss.Serialize(jsonStream, people);

            jsonStream.Dispose();
            WriteLine();
            WriteLine($"Written {new FileInfo(jsonFilepath).Length} bytes of JSON to: {jsonFilepath}");

            WriteLine(File.ReadAllText(jsonFilepath));
        }
    }
}