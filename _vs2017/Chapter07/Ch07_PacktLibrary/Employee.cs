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
        
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public void Info() {
            WriteLine($"{ID}\n{Name}\n{DateOfBirth}\n{Location}\n{Section}\n{Profile}");
        }

        public new void WriteToConsole() {
            WriteLine($"{Name}'s birth date is {DateOfBirth:dd/MM/yy} and hire date was {HireDate:dd/MM/yy}");
        }

        public override string ToString() {
            return $"{Name}'s code is {EmployeeCode}";
        }
    }
}
