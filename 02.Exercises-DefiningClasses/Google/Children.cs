using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exercises_DefiningClasses.Google
{
  public  class Children
    {
        public string Name { get; set; }
        public string DayOfBirth { get; set; }

        public Children(string name, string date)
        {
            DayOfBirth = date;
            this.Name = name;
        }

    }
}
