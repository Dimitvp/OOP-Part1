using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exercises_DefiningClasses.Google
{
   public class Car
    {
        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }
        public string Model { get; set; }
        public int Speed { get; set; }
    }
}
