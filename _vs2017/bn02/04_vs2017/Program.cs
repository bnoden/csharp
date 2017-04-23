using System;
using System.Xml.Linq;
using static System.Console;

namespace _04_vs2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XDocument();

            string city = "";

            while (city.Length < 1) {
                Write("Enter city name: ");
                city = ReadLine();
            }

            WriteLine($"\n{city} has {city.Length} characters.");
            WriteLine($"The first char is '{city[0]}' and the last char is '{city[city.Length-1]}'.");
            if (city.Length > 2 && city.Length%2!=0) {
                WriteLine($"The middle char is '{city[city.Length/2]}'.");
            } else if (city.Length > 3 && city.Length%2==0) {
                WriteLine($"The middle chars are '{city[(city.Length/2)-1]}' and '{city[city.Length/2]}'.");
            }
        }
    }
}