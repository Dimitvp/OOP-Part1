using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    #region Problem 7.	Speed Racing
    //public Car(string model, double fuel, double fuelCost)
    //{
    //    this.Model = model;
    //    this.FuelAmount = fuel;
    //    this.FuelCostPerKilometer = fuelCost;
    //}

    //public void Drive(double distance)
    //{
    //    if (distance * FuelCostPerKilometer <= FuelAmount)
    //    {
    //        this.DistanceTraveled += distance;
    //        this.FuelAmount -= distance * FuelCostPerKilometer;
    //    }
    //    else
    //    {
    //        Console.WriteLine("Insufficient fuel for the drive");
    //    }
    //}
    //public string Model { get; }
    //public double FuelAmount { get; set; }
    //public double FuelCostPerKilometer { get; }
    //public double DistanceTraveled { get; set; }


    #endregion

    #region Problem 8.	Raw Data

    ////“<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> 
    //public Car(string model, int eSpeed, int ePower, int cWeight, string cType, List<Tire> tires)
    //{
    //    this.Model = model;
    //    this.Tires = new List<Tire>(tires);
    //    this.Engine = new Engine(engineSpeed: eSpeed, enginePower: ePower);
    //    this.Cargo = new Cargo(cargoWeight: cWeight, cargoType: cType);
    //}
    //public string Model { get; }
    //public Engine Engine { get; set; }
    //public Cargo Cargo { get; set; }
    //public List<Tire> Tires { get; set; }

    #endregion

    #region Problem 10.	Car Salesman
    public Car(string model, Engine engine, int weight)
: this(model, engine)
    {
        this.Weight = weight;
    }
    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
    }

    public Car(string model, Engine engine, string color)
        : this(model, engine)
    {
        this.Color = color;
    }
    public Car(string model, Engine engine, int weight, string color)
        : this(model, engine, color)
    {
        this.Weight = weight;

    }
    // A Car has a model, engine, weight and color
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public int Weight { get; set; }
    public string Color { get; set; }
    #endregion


}
