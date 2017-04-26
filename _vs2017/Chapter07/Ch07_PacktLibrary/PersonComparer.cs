using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y) {
            int a = x.Name.Length.CompareTo(y.Name.Length);
            int b = x.Name.CompareTo(y.Name);

            return a == 0 ? b : a;
        }
    }
}
