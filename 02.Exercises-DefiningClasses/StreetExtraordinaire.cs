using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exercises_DefiningClasses
{
    class StreetExtraordinaire : Cat
    {
        public double DecibelsOfMeows { get; set; }
        public StreetExtraordinaire(string name, double decibelsOfMeows) : base(name)
        {
            this.DecibelsOfMeows = decibelsOfMeows;
            this.Breed = "StreetExtraordinaire";
        }

        public override string ToString()
        {
            return $"{this.Breed} {this.Name} {this.DecibelsOfMeows}";
        }
    }
}
