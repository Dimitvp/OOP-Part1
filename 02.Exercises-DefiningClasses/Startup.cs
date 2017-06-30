using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _02.Exercises_DefiningClasses.Google;

namespace _02.Exercises_DefiningClasses
{
    class Startup
    {
        static void Main(string[] args)
        {
            #region Problem 1.	Define a class Person

            //Type personType = typeof(Person);
            //FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            //Console.WriteLine(fields.Length);


            #endregion

            #region Problem 2.	Creating Constructors

            //Type personType = typeof(Person);
            //ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
            //ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
            //ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
            //bool swapped = false;
            //if (nameAgeCtor == null)
            //{
            //    nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
            //    swapped = true;
            //}

            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());

            //Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
            //Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
            //Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

            //Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
            //Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
            //Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);

            #endregion

            #region Problem 3.	Oldest Family Member

            //MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            //MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            //if (oldestMemberMethod == null || addMemberMethod == null)
            //{
            //    throw new Exception();
            //}

            //var familySize = int.Parse(Console.ReadLine());
            //var family = new Family();
            //for (int i = 0; i < familySize; i++)
            //{
            //    var person = Console.ReadLine().Split();
            //    family.AddMember(new Person(person[0],int.Parse(person[1])));
            //}
            //Console.WriteLine($"{family.GetOldestMember().name} {family.GetOldestMember().age}");



            #endregion

            #region Problem 4.	Opinion Poll

            //var familySize = int.Parse(Console.ReadLine());
            //var family = new Family();
            //for (int i = 0; i < familySize; i++)
            //{
            //    var person = Console.ReadLine().Split();
            //    family.AddMember(new Person(person[0], int.Parse(person[1])));
            //}

            //foreach (var person in family.people.Where(x => x.age>30).OrderBy(x => x.name))
            //{
            //    Console.WriteLine($"{person.name} - {person.age}");
            //}


            #endregion

            #region Problem 5.	Date Modifier

            //var date1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var date2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var diff = new DateModifier(new DateTime(date1[0], date1[1], date1[2]), new DateTime(date2[0], date2[1], date2[2]));
            //Console.WriteLine(diff.GetDiference());


            #endregion

            #region Problem 6.	Company Roster

            //var size = int.Parse(Console.ReadLine());
            //var company = new List<Employee>();
            //for (int i = 0; i < size; i++)
            //{

            //    var data = Console.ReadLine().Split().ToArray();
            //    var name = data[0];
            //    var sallary = double.Parse(data[1]);
            //    var position = data[2];
            //    var department = data[3];

            //    var employee = new Employee(name, sallary, position, department);
            //    if (data.Length == 5)
            //    {
            //        if (data[4].Contains("@"))
            //        {
            //            employee.Email = data[4];
            //        }
            //        else
            //        {
            //            employee.Age = int.Parse(data[4]);
            //        }

            //    }

            //    if (data.Length == 6)
            //    {
            //        employee.Email = data[4];
            //        employee.Age = int.Parse(data[5]);
            //        //if (data[4].Contains("@"))
            //        //{
            //        //    employee.Email = data[4];
            //        //    employee.Age = int.Parse(data[5]);
            //        //}
            //        //else
            //        //{
            //        //    employee.Age = int.Parse(data[4]);
            //        //    employee.Email = data[5];
            //        //}
            //    }
            //    company.Add(employee);

            //}

            //var highestAverageSalary = double.MinValue;
            //var highestAverageSalaryDepartment = "";
            //var departments = company.Select(x => x.Department).Distinct().ToArray();


            //foreach (var dept in departments)
            //{
            //    var departmentSalary = company.Where(x => x.Department == dept).Sum(x => x.Salary);
            //    if (departmentSalary > highestAverageSalary)
            //    {
            //        highestAverageSalary = departmentSalary;
            //        highestAverageSalaryDepartment = dept;
            //    }
            //}

            //Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment}");
            //foreach (var emp in company.Where(x => x.Department == highestAverageSalaryDepartment).OrderByDescending(x => x.Salary))
            //{
            //    Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
            //}


            #endregion

            #region Problem 7.	Speed Racing

            //int carNumber = int.Parse(Console.ReadLine());
            //List<Car> cars = new List<Car>();
            //for (int i = 0; i < carNumber; i++)
            //{
            //    //BMW-M2 45 0.42
            //    string[] command =
            //       Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    Car car = new Car(model: command[0], fuel: double.Parse(command[1]), fuelCost: double.Parse(command[2]));
            //    cars.Add(car);
            //}
            //string[] laps =
            //       Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //while (laps[0] != "End")
            //{
            //    Car currentCar = cars.FirstOrDefault(x => x.Model == laps[1]);
            //    currentCar.Drive(double.Parse(laps[2]));
            //    laps =
            //       Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //}

            //if (cars.Count > 0)
            //{
            //    foreach (Car car in cars)
            //    {
            //        Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            //    }
            //}

            #endregion

            #region Problem 8.	Raw Data

            //int carNumber = int.Parse(Console.ReadLine());
            //List<Car> cars = new List<Car>();
            //for (int i = 0; i < carNumber; i++)
            //{
            //    string[] command =
            //        Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    // <Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>” 

            //    List<Tire> currenTires = new List<Tire>();
            //    currenTires.Add(new Tire(double.Parse(command[5]), int.Parse(command[6])));
            //    currenTires.Add(new Tire(double.Parse(command[7]), int.Parse(command[8])));
            //    currenTires.Add(new Tire(double.Parse(command[9]), int.Parse(command[10])));
            //    currenTires.Add(new Tire(double.Parse(command[11]), int.Parse(command[12])));

            //    Car currentCar = new Car(model: command[0], eSpeed: int.Parse(command[1]),
            //        ePower: int.Parse(command[2]), cWeight: int.Parse(command[3]), cType: command[4],
            //        tires: currenTires);

            //    cars.Add(currentCar);
            //}

            //string condition = Console.ReadLine();

            //if (cars.Count > 0)
            //{
            //    if (condition == "fragile")
            //    {
            //        foreach (Car car in cars.Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(tp => tp.Pressure < 1.00)))
            //        {
            //            Console.WriteLine(car.Model);
            //        }
            //    }

            //    if (condition == "flamable")
            //    {
            //        foreach (Car car in cars.Where(c => c.Cargo.CargoType == "flamable").Where(e => e.Engine.EnginePower > 250))
            //        {
            //            Console.WriteLine(car.Model);
            //        }
            //    }
            //}


            #endregion

            #region Problem 9.	Rectangle Intersection

            //int[] param = Console.ReadLine()
            //                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            //                        .ToArray();
            //int recNum = param[0];
            //int intersecCheck = param[1];

            //Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

            //for (int i = 0; i < recNum; i++)
            //{
            //    string[] dateStrings = Console.ReadLine()
            //                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //                        .ToArray();
            //    Rectangle rectangle = new Rectangle(dateStrings[0], double.Parse(dateStrings[1]), double.Parse(dateStrings[2]), new double[] { double.Parse(dateStrings[3]), double.Parse(dateStrings[4]) });

            //    rectangles[dateStrings[0]] = rectangle;
            //}

            //for (int i = 0; i < intersecCheck; i++)
            //{
            //    string[] recIds = Console.ReadLine()
            //                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //                        .ToArray();

            //    if (rectangles.ContainsKey(recIds[0]) && rectangles.ContainsKey(recIds[1]))
            //    {
            //        Console.WriteLine(Rectangle.Intersect(rectangles[recIds[0]], rectangles[recIds[1]]).ToString().ToLower());
            //    }
            //}


            #endregion

            #region Problem 10.	Car Salesman

            //int engineCount = int.Parse(Console.ReadLine());
            //List<Engine> engines = new List<Engine>();
            //for (int i = 0; i < engineCount; i++)
            //{
            //    string[] command =
            //        Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //    if (command.Length == 2)
            //    {
            //        //“<Model> <Power> <Displacement> <Efficiency>
            //        Engine currentEngine = new Engine(model: command[0], power: int.Parse(command[1]));
            //        engines.Add(currentEngine);
            //    }

            //    if (command.Length == 3)
            //    {
            //        int disp = 0;
            //        int.TryParse(command[2], out disp);
            //        if (disp != 0)
            //        {
            //            //<Model> <Power> <Displacement>
            //            Engine currentEngine = new Engine(model: command[0], power: int.Parse(command[1]), displacement: command[2]);
            //            engines.Add(currentEngine);
            //        }
            //        else
            //        {
            //            //“<Model> <Power> <Efficiency>
            //            Engine currentEngine = new Engine(model: command[0], power: int.Parse(command[1]), efficiency: command[2]);
            //            engines.Add(currentEngine);
            //        }


            //    }

            //    if (command.Length == 4)
            //    {
            //        //“<Model> <Power> <Displacement> <Efficiency>
            //        Engine currentEngine = new Engine(model: command[0], power: int.Parse(command[1]), efficiency: command[3], displacement: command[2]);
            //        engines.Add(currentEngine);
            //    }
            //}

            //int carCount = int.Parse(Console.ReadLine());
            //List<Car> cars = new List<Car>();
            //for (int i = 0; i < carCount; i++)
            //{
            //    string[] command =
            //        Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    Engine eng = engines.FirstOrDefault(x => x.Model == command[1]);

            //    if (command.Length == 2)
            //    {
            //        //“<Model> <Engine> <Weight> <Color>
            //        Car car = new Car(model: command[0], engine: eng);
            //        cars.Add(car);
            //    }

            //    if (command.Length == 3)
            //    {
            //        int wei = 0;
            //        int.TryParse(command[2], out wei);
            //        if (wei != 0)
            //        {
            //            Car car = new Car(model: command[0], engine: eng, weight: int.Parse(command[2]));

            //            //“<Model> <Engine> <Weight> 
            //            cars.Add(car);

            //        }
            //        else
            //        {
            //            //“<Model> <Engine> <Weight> <Color>
            //            Car car = new Car(model: command[0], engine: eng, color: command[2]);
            //            cars.Add(car);

            //        }

            //    }

            //    if (command.Length == 4)
            //    {
            //        //“<Model> <Engine> <Weight> <Color>
            //        Car car = new Car(model: command[0], engine: eng, weight: int.Parse(command[2]), color: command[3]);
            //        cars.Add(car);
            //    }
            //}


            //foreach (Car car in cars)
            //{
            //    //FordFocus:
            //    //V4 - 33:
            //    //  Power: 140
            //    //  Displacement: 28
            //    //  Efficiency: B
            //    //Weight: 1300
            //    //Color: Silver

            //    Console.WriteLine($"{car.Model}:");
            //    Console.WriteLine($"  {car.Engine.Model}:");
            //    Console.WriteLine($"    Power: {car.Engine.Power}");
            //    if (!string.IsNullOrEmpty(car.Engine.Displacement))
            //    {
            //        Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"    Displacement: n/a");
            //    }

            //    if (!string.IsNullOrEmpty(car.Engine.Efficiency))
            //    {
            //        Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"    Efficiency: n/a");
            //    }

            //    if (car.Weight != 0)
            //    {
            //        Console.WriteLine($"  Weight: {car.Weight}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"  Weight: n/a");
            //    }

            //    if (!string.IsNullOrEmpty(car.Color))
            //    {
            //        Console.WriteLine($"  Color: {car.Color}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"  Color: n/a");
            //    }

            //}

            #endregion

            #region Problem 11.	Pokemon Trainer

            //string command = Console.ReadLine();
            //List<Trainer> trainers = new List<Trainer>();
            //while (command != "Tournament")
            //{
            //    string[] commands =
            //        command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    // “<TrainerName> <PokemonName> <PokemonElement> <PokemonHealth>
            //    Pokemon currentPokemon = new Pokemon(commands[1], commands[2], int.Parse(commands[3]));
            //    Trainer curretTrainer = new Trainer(commands[0]);
            //    if (trainers.Count(x => (x.Name == commands[0])) > 0)
            //    {
            //        foreach (var tr in trainers)
            //        {
            //            if (tr.Name == commands[0])
            //            {
            //                tr.Pokemons.Add(currentPokemon);

            //                // check if the trainer already has this pokemon
            //            }
            //        }
            //    }
            //    else
            //    {
            //        curretTrainer.Pokemons.Add(currentPokemon);
            //        trainers.Add(curretTrainer);
            //    }

            //    command = Console.ReadLine();
            //}
            //command = Console.ReadLine();
            //while (command != "End")
            //{
            //    foreach (Trainer trainer in trainers)
            //    {
            //        trainer.AttackElement(command);
            //    }

            //    command = Console.ReadLine();
            //}


            //if (trainers.Count > 0)
            //{
            //    foreach (var trainer in trainers.OrderByDescending(x => x.Badges))
            //    {
            //        //Console.WriteLine($"++{trainer.Name}");
            //        //foreach (var pok in trainer.Pokemons)
            //        //{
            //        //    Console.WriteLine($"{pok.Name} {pok.Health}"); 
            //        //}
            //        Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count(p => p.Health > 0)}");

            //    }
            //}


            #endregion

            #region Problem 12.	Google

            //        string command = Console.ReadLine();
            //        var persons = new List<Google.Person>();
            //        while (command != "End")
            //        {
            //            string[] commands =
            //command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //            var currenPerson = new Google.Person(commands[0]);



            //            switch (commands[1])
            //            {
            //                case "company":
            //                    //uniqe
            //                    //•	“< Name > company < companyName > < department > < salary >”
            //                    if (persons.Any(x => x.Name == commands[0]))
            //                    {
            //                        var existingPerson = persons.First(x => x.Name == commands[0]);
            //                        existingPerson.Company = commands[2];
            //                        existingPerson.Department = commands[3];
            //                        existingPerson.Salary = decimal.Parse(commands[4]);
            //                    }
            //                    else
            //                    {
            //                        currenPerson.Company = commands[2];
            //                        currenPerson.Department = commands[3];
            //                        currenPerson.Salary = decimal.Parse(commands[4]);
            //                        persons.Add(currenPerson);
            //                    }
            //                    break;
            //                case "pokemon":
            //                    //
            //                    //•	“< Name > pokemon < pokemonName > < pokemonType >”
            //                    if (persons.Any(x => x.Name == commands[0]))
            //                    {
            //                        var existingPerson = persons.First(x => x.Name == commands[0]);
            //                        existingPerson.Pokemons.Add(new Google.Pokemon(commands[2], commands[3]));
            //                    }
            //                    else
            //                    {
            //                        currenPerson.Pokemons.Add(new Google.Pokemon(commands[2], commands[3]));
            //                        persons.Add(currenPerson);
            //                    }
            //                    break;
            //                case "parents":
            //                    //
            //                    //•	“< Name > parents < parentName > < parentBirthday >”
            //                    if (persons.Any(x => x.Name == commands[0]))
            //                    {
            //                        var existingPerson = persons.First(x => x.Name == commands[0]);
            //                        existingPerson.Parents.Add(new Google.Parent(commands[2], commands[3]));
            //                    }
            //                    else
            //                    {
            //                        currenPerson.Parents.Add(new Parent(commands[2], commands[3]));
            //                        persons.Add(currenPerson);
            //                    }
            //                    break;
            //                case "children":
            //                    //
            //                    //•	“< Name > children < childName > < childBirthday >”
            //                    if (persons.Any(x => x.Name == commands[0]))
            //                    {
            //                        var existingPerson = persons.First(x => x.Name == commands[0]);
            //                        existingPerson.Childrens.Add(new Children(commands[2], commands[3]));
            //                    }
            //                    else
            //                    {
            //                        currenPerson.Childrens.Add(new Children(commands[2], commands[3]));
            //                        persons.Add(currenPerson);
            //                    }
            //                    break;
            //                case "car":
            //                    //uniqe
            //                    //•	“< Name > car < carModel > < carSpeed >”
            //                    if (persons.Any(x => x.Name == commands[0]))
            //                    {
            //                        var existingPerson = persons.First(x => x.Name == commands[0]);
            //                        var cCar = new Google.Car(commands[2], int.Parse(commands[3]));
            //                        existingPerson.Car = cCar;
            //                    }
            //                    else
            //                    {
            //                        var cCar = new Google.Car(commands[2], int.Parse(commands[3]));
            //                        currenPerson.Car = cCar; ;
            //                        persons.Add(currenPerson);
            //                    }
            //                    break;
            //            }

            //            command = Console.ReadLine();
            //        }
            //        command = Console.ReadLine();

            //        if (persons.Any(x => x.Name == command))
            //        {
            //            var existingPerson = persons.First(x => x.Name == command);
            //            //TonchoTonchev
            //            //Company:
            //            //Car:
            //            //Trabant 30
            //            //Pokemon:
            //            //Electrode Electricity
            //            //Parents:
            //            //Children:

            //            Console.WriteLine(existingPerson.Name);
            //            Console.WriteLine($"Company:");
            //            if (existingPerson.Company != null)
            //            {
            //                Console.WriteLine($"{existingPerson.Company} {existingPerson.Department} {existingPerson.Salary:f2}");

            //            }
            //            Console.WriteLine($"Car:");
            //            if (existingPerson.Car != null)
            //            {
            //                Console.WriteLine($"{existingPerson.Car.Model} {existingPerson.Car.Speed}");
            //            }
            //            Console.WriteLine($"Pokemon:");
            //            existingPerson.Pokemons.ForEach(x => Console.WriteLine($"{x.Name} {x.Type}"));
            //            Console.WriteLine($"Parents:");
            //            existingPerson.Parents.ForEach(x => Console.WriteLine($"{x.Name} {x.DayOfBirth}"));
            //            Console.WriteLine($"Children:");
            //            existingPerson.Childrens.ForEach(x => Console.WriteLine($"{x.Name} {x.DayOfBirth}"));
            //        }
            // }

            #endregion

            #region Problem 13.	Family Tree
            //string fisrCommand = Console.ReadLine();
            //string input = Console.ReadLine();

            //List<Person> familyMembers = new List<Person>();

            //List<string> commandHistory = new List<string>();

            ////get all commands
            //input = CreateHistory(input, commandHistory);

            ////contains only relationships commands 
            //List<string> treeCommands = new List<string>();

            ////extract family members data and filters the command stack
            //CreateFamily(familyMembers, commandHistory, treeCommands);

            //PopulateRelationships(familyMembers, treeCommands);

            //PrintResult(fisrCommand, familyMembers);


            #endregion

            #region Problem 14.	*Cat Lady
            //string command = Console.ReadLine();
            //List<Siamese> siCatList = new List<Siamese>();
            //List<Cymric> cyCatList = new List<Cymric>();
            //List<StreetExtraordinaire> stCatList = new List<StreetExtraordinaire>();
            //while (command != "End")
            //{
            //    string[] commands = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //    AddCats(siCatList, cyCatList, stCatList, commands);
            //    command = Console.ReadLine();
            //}
            //command = Console.ReadLine();
            //PrintCat(command, siCatList, cyCatList, stCatList);


            #endregion

            #region Problem 15.	*Drawing tool
            string figure = Console.ReadLine();
            if (figure == "Square")
            {
                int width = int.Parse(Console.ReadLine());
                CorDraw.Draw(figure, width);
            }
            else
            {
                int width = int.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                CorDraw.Draw(figure, width, height);
            }

            #endregion


        }

        #region Problem 14.	*Cat Lady - Methods
        private static void AddCats(List<Siamese> siCatList, List<Cymric> cyCatList, List<StreetExtraordinaire> stCatList, string[] commands)
        {
            switch (commands[0])
            {
                case "Siamese"://•	“Siamese < name > < earSize >”
                    Siamese SiCat = new Siamese(commands[1], double.Parse(commands[2]));
                    siCatList.Add(SiCat);
                    break;
                case "Cymric"://•	“Cymric < name > < furLength >”
                    Cymric CyCat = new Cymric(commands[1], double.Parse(commands[2]));
                    cyCatList.Add(CyCat);
                    break;
                case "StreetExtraordinaire"://•	“StreetExtraordinaire < name > < decibelsOfMeows >”
                    StreetExtraordinaire StCat = new StreetExtraordinaire(commands[1], double.Parse(commands[2]));
                    stCatList.Add(StCat);
                    break;
            }
        }

        private static void PrintCat(string command, List<Siamese> siCatList, List<Cymric> cyCatList, List<StreetExtraordinaire> stCatList)
        {
            if (siCatList.Count > 0)
            {
                var cat = siCatList.FirstOrDefault(x => x.Name == command);

                if (cat != null)
                {
                    Console.WriteLine(cat.ToString());
                }
            }

            if (cyCatList.Count > 0)
            {

                var cat = cyCatList.FirstOrDefault(x => x.Name == command);
                if (cat != null)
                {
                    Console.WriteLine(cat.ToString());

                }
            }

            if (stCatList.Count > 0)
            {
                var cat = stCatList.FirstOrDefault(x => x.Name == command);
                if (cat != null)
                {
                    Console.WriteLine(cat.ToString());
                }
            }
        }
        #endregion

        #region Problem 13.	Family Tree - Methods
        private static void CreateFamily(List<Person> familyMembers, List<string> commandHistory, List<string> treeCommands)
        {
            foreach (string command in commandHistory)
            {
                if (!command.Contains("-"))
                {
                    // person data
                    AddFamilyMembers(familyMembers, command);
                }
                else
                {
                    // relationships data
                    treeCommands.Add(command);
                }
            }
        }

        private static void PrintResult(string fisrCommand, List<Person> familyMembers)
        {
            if (fisrCommand != null)
            {
                Person resulPerson;
                if (fisrCommand.Contains("/"))
                {
                    //find by date
                    resulPerson = familyMembers.Find(x => x.DateOfBirth == fisrCommand);
                }
                else
                {
                    //find by name
                    resulPerson = familyMembers.Find(x => x.Name == fisrCommand);
                }

                Console.WriteLine($"{resulPerson.Name} {resulPerson.DateOfBirth}");
                Console.WriteLine("Parents:");
                if (resulPerson.Parents.Count > 0)
                {

                    resulPerson.Parents.ForEach(x => Console.WriteLine($"{x.Name} {x.DateOfBirth}"));
                }
                Console.WriteLine("Children:");

                if (resulPerson.Childs.Count > 0)
                {
                    resulPerson.Childs.ForEach(x => Console.WriteLine($"{x.Name} {x.DateOfBirth}"));
                }

            }
        }

        private static void PopulateRelationships(List<Person> familyMembers, List<string> treeCommands)
        {
            foreach (var comm in treeCommands)
            {
                string[] commands = comm.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commands[0].Contains("/"))
                {
                    // <date> <???>
                    if (commands[1].Contains("/"))
                    {
                        // <date> <date>
                        Person parent = familyMembers.First(x => x.DateOfBirth == commands[0]);
                        Person child = familyMembers.First(x => x.DateOfBirth == commands[1]);

                        parent.Childs.Add(child);
                        child.Parents.Add(parent);
                    }
                    else
                    {
                        // <date> <name>
                        Person parent = familyMembers.First(x => x.DateOfBirth == commands[0]);
                        Person child = familyMembers.First(x => x.Name == commands[1]);

                        parent.Childs.Add(child);
                        child.Parents.Add(parent);
                    }
                }
                else
                {
                    // <name> <???>
                    if (commands[1].Contains("/"))
                    {
                        // <name> <date>
                        Person parent = familyMembers.First(x => x.Name == commands[0]);
                        Person child = familyMembers.First(x => x.DateOfBirth == commands[1]);

                        parent.Childs.Add(child);
                        child.Parents.Add(parent);
                    }
                    else
                    {
                        // <name> <name>
                        Person parent = familyMembers.First(x => x.Name == commands[0]);
                        Person child = familyMembers.First(x => x.Name == commands[1]);

                        parent.Childs.Add(child);
                        child.Parents.Add(parent);
                    }
                }

            }
        }

        private static void AddFamilyMembers(List<Person> persons, string command)
        {
            string[] commands = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = commands[0] + " " + commands[1];
            Person person = new Person(name, commands[2]);
            persons.Add(person);
        }

        private static string CreateHistory(string input, List<string> history)
        {
            while (input != "End")
            {
                history.Add(input);
                input = Console.ReadLine();
            }

            return input;
        }
        #endregion
    }
}



