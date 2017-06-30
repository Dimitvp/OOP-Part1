using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exercises_DefiningClasses
{
    class Cymric : Cat
    {
        public double FurLength { get; set; }

        public Cymric(string name, double furLength) : base(name)
        {
            this.FurLength = furLength;
            this.Breed = "Cymric";
        }

        public override string ToString()
        {
            return $"{this.Breed} {this.Name} {this.FurLength:f2}";

        }
    }
}
