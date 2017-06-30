using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exercises_DefiningClasses
{
    class Siamese : Cat
    {
        public double EarSize { get; set; }
        public Siamese(string name, double earSize) : base(name)
        {
            this.EarSize = earSize;
            this.Breed = "Siamese";
        }

        public override string ToString()
        {
            return $"{this.Breed} {this.Name} {this.EarSize}";
        }
    }
}
