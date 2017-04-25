using System;
using System.Collections.Generic;

namespace Packt.CS7
{
    public class Person
    {

        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;

        public List<Person> Children = new List<Person>();
        
        // read-only fields
        public readonly string HomePlanet = "Earth";
    }
}
