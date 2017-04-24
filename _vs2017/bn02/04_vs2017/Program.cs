using System;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using static System.Console;

namespace _04_vs2017
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime msg = DateTime.Now;
            var doc = new XDocument();
            const int MAX_ATTEMPTS = 3, toBin = 2, toHex = 16;
            const string DEFAULT_ID = "0123456789";
            string isaidno = "";
            
            int attempt = 1;
            var idCheck = new Regex(@"^[0-9]{10}$");
            DateTime dt;
            while(!idCheck.IsMatch(isaidno)) {
                if (attempt>1) { WriteLine($"Attempt {attempt} of {MAX_ATTEMPTS}"); }
                
                Write("10-digit International Secret Agent ID Number: ");
                isaidno = ReadLine();
                attempt++;
                if (!(attempt<=MAX_ATTEMPTS)) {
                    
                    WriteLine("\nMAX_ATTEMPTS reached! Implementing [BITSTRIPE] emergency entry protocol.\n");
                    ReadKey();
                    string bitstripe = "";
                    for (int b = 128; b < 255; b++) {
                        bitstripe=("0b"+Convert.ToString(b, toBin)+" 0x"+Convert.ToString(b*16, toHex)+' ');
                        Write(bitstripe);
                    }
                    dt = DateTime.Now;
                    ReadKey();
                    WriteLine($"\n\nVerification bypassed {dt}");
                    ReadKey();
                    WriteLine("Warning: Connection is not secure and may be monitored.");
                    isaidno = DEFAULT_ID;
                    ReadKey();
                }
            }

            string city = "";

            while (city.Length < 1) {
                Write("Enter city name: ");
                city = ReadLine();
            }
            string[] citySplit = city.Split(' ','.','-','\'');
            string cityJoin = "";
            foreach (string word in citySplit) {
                    cityJoin+=word;
                }

            WriteLine($"\nThere are {cityJoin.Length} letters in {city}.");
            ReadKey();
            WriteLine($"The first letter is '{city[0]}' and the last letter is '{city[city.Length-1]}'.");
            ReadKey();
            if (cityJoin.Length > 2 && cityJoin.Length%2!=0) {
                WriteLine($"The middle letter is '{cityJoin[cityJoin.Length/2]}'.");
            }
            else if (cityJoin.Length > 3 && cityJoin.Length%2==0) {
                WriteLine($"The middle letters are '{cityJoin[(cityJoin.Length/2)-1]}' and '{cityJoin[cityJoin.Length/2]}'.");
            }
            ReadKey();
            bool success = true;
            Write("\nEnter target's full name (first and last): ");
            string fullname = ReadLine();
            
            try {
                int indexOfTheSpace = fullname.IndexOf(' ');
                string firstname = fullname.Substring(0, indexOfTheSpace);
                string lastname = fullname.Substring(indexOfTheSpace + 1);
                string found = firstname.Length>lastname.Length? "inside" : "outside of";
                WriteLine($"{lastname}, {firstname} is currently {found} {city}");
            } catch (ArgumentOutOfRangeException) {
                success = false;
            } finally {
                if (!success) {
                    dt = DateTime.Now;
                    WriteLine($"Invalid input. Attempt logged {dt}");
                    ReadKey();
                } else if (success) {
                    dt = DateTime.Now;
                    ReadKey();
                    WriteLine($"{dt} \tTarget's status updated.");
                }
                ReadKey();
            }

            WriteLine("\nMessages:\n");
            ReadKey();
            WriteLine($"{msg}\t From: Agent 'Gray' #1C0B9AE9A3, DBOZ Specialist");
            ReadKey();
            WriteLine("The latest .NET dictionary update has been released.\n"+
                "Classification: RMD (read memorize destroy)\n");
            ReadKey();

            var keywords = new System.Collections.Generic.Dictionary<string, string>();
            keywords.Add("int", "32-bit integer data type"); 
            keywords.Add("long", "64-bit integer data type"); 
            keywords.Add("float", "Single precision floating point number"); 
            WriteLine("Keywords and their definitions"); 
            foreach (System.Collections.Generic.KeyValuePair<string, string> item in keywords) 
            { 
              WriteLine($"  {item.Key}: {item.Value}"); 
            } 
            WriteLine($"The definition of long is {keywords["long"]}"); 
            ReadKey();

            WriteLine("That is all. Formatting disk...");
            ReadKey();
            WriteLine("...");
            ReadKey();
            WriteLine("...OK");
            

            return;
            
        }
    }
}