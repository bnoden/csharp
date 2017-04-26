using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    public partial class Person
    {

        // C# 1-5 syntax for defining property
        public string Origin {
            get { return $"{Name} was born on {HomePlanet}"; }
        }

        // C# 6+ lambda expression syntax
        public string Greeting => $"{Name} says 'Hey!'";
        public int Age => (int)(System.DateTime
            .Today.Subtract(DateOfBirth).TotalDays/365.25);

        // auto-syntax
        public string FavIceCream { get; set; }

        // manual detailed syntax
        private string favPrimaryColor;
        public string FavPrimaryColor {
            get { return favPrimaryColor; }
            set { switch (value.ToLower()) {
                    case "red":
                    case "green":
                    case "blue":
                    favPrimaryColor = value;
                    break;
                    default:
                        throw new System.ArgumentException(
                            $"{value} is not a primary color. Choose red, green, or blue."
                            );
                } }
        }

    }
}
