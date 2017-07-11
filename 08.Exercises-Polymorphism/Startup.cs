using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Exercises_Polymorphism
{
    class Startup
    {
        static void Main(string[] args)
        {
            #region Vegicles

            //var vehicleData = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
            //var fuelQuantity = double.Parse(vehicleData[1]);
            //var litersPerKm = double.Parse(vehicleData[2]);
            //var tankCapacity = double.Parse(vehicleData[3]);
            //var car = new Car(fuelQuantity, litersPerKm, tankCapacity);

            //vehicleData = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
            //fuelQuantity = double.Parse(vehicleData[1]);
            //litersPerKm = double.Parse(vehicleData[2]);
            //tankCapacity = double.Parse(vehicleData[3]);
            //var truck = new Truck(fuelQuantity, litersPerKm, tankCapacity);

            //vehicleData = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
            //fuelQuantity = double.Parse(vehicleData[1]);
            //litersPerKm = double.Parse(vehicleData[2]);
            //tankCapacity = double.Parse(vehicleData[3]);
            //var bus = new Bus(fuelQuantity, litersPerKm, tankCapacity);

            //var events = int.Parse(Console.ReadLine());

            //for (int i = 0; i < events; i++)
            //{
            //    var currentEventData = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
            //    var currnetEvent = currentEventData[0];
            //    var vehicleType = currentEventData[1];
            //    Vehicle vehicle;
            //    if (vehicleType == "Car")
            //    {
            //        vehicle = car;
            //    }
            //    else if (vehicleType == "Truck")
            //    {
            //        vehicle = truck;
            //    }
            //    else
            //    {
            //        vehicle = bus;
            //    }
            //    var data = double.Parse(currentEventData[2]);
            //    switch (currnetEvent)
            //    {
            //        case "Drive":
            //            Drive(vehicle, data);
            //            break;
            //        case "Refuel":
            //            Refuel(vehicle, data);
            //            break;
            //        case "DriveEmpty":
            //            DriveEmpty(bus, data);
            //            break;
            //    }
            //}

            //Console.WriteLine($"Car: {car.Fuel:f2}");
            //Console.WriteLine($"Truck: {truck.Fuel:f2}");
            //Console.WriteLine($"Bus: {bus.Fuel:f2}");

            #endregion

            #region Problem 3.	Wild farm

            //while (true)
            //{
            //    var input = Console.ReadLine();

            //    if (input == "End")
            //    {
            //        return;
            //    }

            //    var animalData = input.Split(new char[] { ' ' }).ToArray();
            //    // {AnimalType} {AnimalName} {AnimalWeight} {AnimalLivingRegion} [{CatBreed} = Only if its cat]
            //    var animalType = animalData[0];
            //    var animalName = animalData[1];
            //    var animalWeight = double.Parse(animalData[2]);
            //    var animalLivingRegion = animalData[3];
            //    string catBreed = "";
            //    if (animalType == "Cat")
            //    {
            //        catBreed = animalData[4];
            //    }

            //    var animal = TryAnimalCreate(animalType, animalName, animalWeight, animalLivingRegion, catBreed);
            //    animal.MakeSound();
            //    var foodData = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
            //    var foodType = foodData[0];
            //    var foodQuantity = int.Parse(foodData[1]);
            //    var food = CreateFood(foodType, foodQuantity);
            //    try
            //    {
            //        animal.Eat(food);
            //    }
            //    catch (ApplicationException ae)
            //    {
            //        Console.WriteLine(ae.Message);
            //    }
            //    Console.WriteLine(animal);
            //}


            #endregion



        }



        private static Food CreateFood(string foodType, int foodQuantity)
        {
            if (foodType == "Vegetable")
            {
                return new Vegetable(foodQuantity);
            }

            return new Meat(foodQuantity);

        }

        private static Mammal TryAnimalCreate(string animalType, string animalName, double animalWeight, string animalLivingRegion, string catBreed)
        {
            Mammal result = null;
            switch (animalType)
            {
                case "Mouse":
                    result = new Mouse(animalName, animalType, animalWeight, animalLivingRegion);
                    break;
                case "Zebra":
                    result = new Zebra(animalName, animalType, animalWeight, animalLivingRegion);
                    break;
                case "Cat":
                    result = new Cat(animalName, animalType, animalWeight, animalLivingRegion, catBreed);
                    break;
                case "Tiger":
                    result = new Tiger(animalName, animalType, animalWeight, animalLivingRegion);
                    break;
            }

            return result;
        }

        #region Vegicles
        //private static void DriveEmpty(Bus bus, double distance)
        //{
        //    try
        //    {
        //        Console.WriteLine(bus.DriveEmpty(distance));
        //    }
        //    catch (ApplicationException ae)
        //    {
        //        Console.WriteLine(ae.Message);
        //    }
        //}

        //private static void Refuel(Vehicle vehicle, double amounth)
        //{

        //    try
        //    {
        //        vehicle.Refuel(amounth);

        //    }
        //    catch (ApplicationException ae)
        //    {
        //        Console.WriteLine(ae.Message);
        //    }

        //}

        //private static void Drive(Vehicle vehicle, double distance)
        //{
        //    try
        //    {
        //        Console.WriteLine(vehicle.Drive(distance));
        //    }
        //    catch (ApplicationException ae)
        //    {
        //        Console.WriteLine(ae.Message);
        //    }
        //}


        #endregion

    }
}
