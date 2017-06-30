using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exercises_DefiningClasses
{
    class Trainer
    {
        public Trainer(string name)
        {
            this.Pokemons = new List<Pokemon>();
            this.Name = name;
        }
        public string Name { get; }
        private int _badges;
        public int Badges
        {
            get { return this._badges; }
        }
        public List<Pokemon> Pokemons { get; set; }

        public void AttackElement(string element)
        {
            if (Pokemons.Where(p => p.Health > 0).Count(x => x.Element == element) > 0)
            {
                _badges++;
            }
            else
            {
                Pokemons.ForEach(x => x.ReduceHealth());
                //RemovePokemon();
            }


        }

        //private void RemovePokemon()
        //{
        //    foreach (var pokemon in Pokemons)
        //    {
        //        if (pokemon.Health == 0)
        //        {
        //            Pokemons.Remove(pokemon);
        //        }
        //    }
        //}
    }
}
