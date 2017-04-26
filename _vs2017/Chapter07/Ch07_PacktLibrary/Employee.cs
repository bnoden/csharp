using System;
using static System.Console;

namespace Packt.CS7
{
    public class Employee : Person
    {
        public int ID;
        public int Location;
        public string Section;
        public string Profile;

        public void Info() {
            WriteLine($"{ID}\n{Name}\n{DateOfBirth}\n{Location}\n{Section}\n{Profile}");
        }
    }
}
