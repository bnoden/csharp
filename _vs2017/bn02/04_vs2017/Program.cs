using System;
using System.IO;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using static System.Console;

namespace _04_vs2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XDocument();
            const int MAX_ATTEMPTS = 3;
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
                    
                    WriteLine("\nTop-level supersecret agent has implementd [BITSTRIPE] protocol.\n");

                    int toBin = 2;
                    int toHex = 16;
                    
                    for (int b = 128; b < 255; b++) {
                        Write("0b"+Convert.ToString(b, toBin)
                            +" 0x"+Convert.ToString(b*16, toHex)+' ');
                    }
                    dt = DateTime.Now;
                    WriteLine($"\n\nVerification bypassed {dt}");
                    WriteLine("Warning: Connection is not secure and may be monitored.");
                    isaidno = "0123456789";
                }
            }

            string c = "";

            while (c.Length < 1) {
                Write("Enter city name: ");
                c = ReadLine();
            }
            string[] cSplit = c.Split(' ');
            string cJoin = "";
            foreach (string word in cSplit) {
                    cJoin+=word;
                }
            //WriteLine(cityJoin);
            WriteLine($"\nThere are {cJoin.Length} letters in {c}.");
            WriteLine($"The first letter is '{c[0]}' and the last letter is '{c[c.Length-1]}'.");
            if (cJoin.Length > 2 && cJoin.Length%2!=0) {
                WriteLine($"The middle letter is '{cJoin[cJoin.Length/2]}'.");
            } else if (cJoin.Length > 3 && cJoin.Length%2==0) {
                WriteLine($"The middle letters are '{cJoin[(cJoin.Length/2)-1]}' and '{cJoin[cJoin.Length/2]}'.");
            }

            bool success = true;
            Write("\nEnter full name (first and last): ");
            string fullname = ReadLine();
            
            try {
                int indexOfTheSpace = fullname.IndexOf(' ');
                string firstname = fullname.Substring(0, indexOfTheSpace);
                string lastname = fullname.Substring(indexOfTheSpace + 1);
                string found = firstname.Length>lastname.Length? "inside" : "outside of";
            WriteLine($"{lastname}, {firstname} is currently {found} {c}");
            } catch (ArgumentOutOfRangeException) {
                success = false;
            } finally {
                if (!success) {
                    dt = DateTime.Now;
                    WriteLine($"Invalid input. Attempt logged {dt}");
                }
                WriteLine("Goodbye.");
            }

            

            return;
            
        }
    }
}