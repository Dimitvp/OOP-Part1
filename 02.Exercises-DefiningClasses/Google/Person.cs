using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exercises_DefiningClasses.Google
{
  public  class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Parents = new List<Parent>();
            this.Childrens = new List<Children>();
            this.Pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Google.Car Car { get; set; }
        public List<Google.Parent> Parents { get; set; }
        public List<Google.Children> Childrens { get; set; }
        public List<Google.Pokemon> Pokemons { get; set; }



    }


}
