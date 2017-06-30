using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exercises_DefiningClasses
{
    public class Cat
    {
        public Cat(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public string Breed { get; set; }
    }
}
