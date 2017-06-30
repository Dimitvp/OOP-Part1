using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Tire
{
    public Tire(double pressure, int age)
    {
        this.Age = age;
        this.Pressure = pressure;
    }
    public int Age { get; set; }
    public double Pressure { get; set; }
}

