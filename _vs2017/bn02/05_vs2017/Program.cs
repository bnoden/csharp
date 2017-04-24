using System;
using System.Globalization;
using static System.Console;

namespace _05_vs2017
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo globalization = CultureInfo.CurrentCulture;
            CultureInfo localization = CultureInfo.CurrentUICulture;
            WriteLine($"The current globalization culture is {globalization.Name}: {globalization.DisplayName}"); 
            WriteLine($"The current localization culture is {localization.Name}: {localization.DisplayName}"); 
            WriteLine(); 
            WriteLine("en-US: English (United States)");
            WriteLine("en-GB: English (United Kingdom)");
            WriteLine("fr-CA: French (Canada)");
            WriteLine("fr-FR: French (France)");
            WriteLine("es-MX: Spanish (Mexico)");
            WriteLine("es-ES: Spanish (Spain)");
            WriteLine("de-DE: German (Germany)");

            Write("\nEnter an ISO culture code: ");

            string newculture = ReadLine(); 

            if (!string.IsNullOrEmpty(newculture)) {
                var ci = new CultureInfo(newculture);
                CultureInfo.CurrentCulture = ci;
                CultureInfo.CurrentUICulture = ci;
            } 

            
            
            try {
                Write("Enter your name: ");
                string name = ReadLine();
                Write("Enter your date of birth: ");
                string dob = ReadLine();
                Write("Enter your salary: ");
                string salary = ReadLine();
                DateTime date = DateTime.Parse(dob);
                int minutes = (int)DateTime.Today.Subtract(date).TotalMinutes;
                decimal earns = decimal.Parse(salary);
                WriteLine($"{name} was born on a {date:dddd} and is {minutes:N0} minutes old and earns {earns:C}.");
            } catch (System.FormatException) {
                //WriteLine("Localization is not available for ps-PS: (Philistia).");
                WriteLine("You did not cooperate. You do not get to enjoy the localization.");
                WriteLine("Goodbye.");
            }

        }
    }
}