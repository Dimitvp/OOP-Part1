using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Engine
{
    //public Engine(int enginePower, int engineSpeed)
    //{
    //    this.EnginePower = enginePower;
    //    this.EngineSpeed = EngineSpeed;
    //}
    //public int EnginePower { get; set; }
    //public int EngineSpeed { get; set; }

    #region Problem 10.	Car Salesman
    public Engine(string model, string efficiency, int power)
    {
        this.Model = model;
        this.Power = power;
        this.Efficiency = efficiency;
    }
    public Engine(string model, int power)
    {
        this.Model = model;
        this.Power = power;
    }
    public Engine(string model, int power, string displacement)
        : this(model, power)
    {
        this.Displacement = displacement;
    }

    public Engine(string model, int power, string displacement, string efficiency)
        : this(model, power, displacement)
    {
        this.Efficiency = efficiency;

    }
    //An Engine has model, power, displacement and efficiency
    public string Model { get; set; }
    public int Power { get; set; }
    public string Displacement { get; set; }
    public string Efficiency { get; set; }
    #endregion

}
