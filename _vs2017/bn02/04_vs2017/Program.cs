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
            string[] citySplit = city.Split(' ');
            string cityJoin = "";
            foreach (string word in citySplit) {
                    cityJoin+=word;
                }
            //WriteLine(cityJoin);
            WriteLine($"\nThere are {cityJoin.Length} letters in {city}.");
            WriteLine($"The first char is '{city[0]}' and the last char is '{city[city.Length-1]}'.");
            if (cityJoin.Length > 2 && cityJoin.Length%2!=0) {
                WriteLine($"The middle char is '{cityJoin[cityJoin.Length/2]}'.");
            } else if (cityJoin.Length > 3 && cityJoin.Length%2==0) {
                WriteLine($"The middle chars are '{cityJoin[(cityJoin.Length/2)-1]}' and '{cityJoin[cityJoin.Length/2]}'.");
            }

            Write("Enter full name (first and last): ");
            string fullname = ReadLine();
            int indexOfTheSpace = fullname.IndexOf(' ');
            string firstname = fullname.Substring(0, indexOfTheSpace);
            string lastname = fullname.Substring(indexOfTheSpace + 1);
            string found = firstname.Length>lastname.Length? "was" : "could not be";
            WriteLine($"{lastname}, {firstname} {found} found in {city}");

            return;
            
        }
    }
}