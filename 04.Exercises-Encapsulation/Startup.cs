using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        #region Problem 1.	Class Box
        //Type boxType = typeof(Box);
        //FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        //Console.WriteLine(fields.Count());

        //// length, width and height

        //double length = double.Parse(Console.ReadLine());
        //double width = double.Parse(Console.ReadLine());
        //double height = double.Parse(Console.ReadLine());

        //Box box = new Box(width, height, length);
        //box.GetSurfaceArea();
        //box.GetLateralSurface();
        //box.GetVolume();


        #endregion

        #region Problem 2.	Class Box Data Validation
        //Type boxType = typeof(Box);
        //FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        //Console.WriteLine(fields.Count());

        //// length, width and height

        //double length = double.Parse(Console.ReadLine());
        //double width = double.Parse(Console.ReadLine());
        //double height = double.Parse(Console.ReadLine());

        //try
        //{
        //    Box box = new Box(width, height, length);
        //    box.GetSurfaceArea();
        //    box.GetLateralSurface();
        //    box.GetVolume();
        //}
        //catch (ApplicationException ae)
        //{
        //    Console.WriteLine(ae.Message);
        //}


        #endregion

        #region Problem 4.	Shopping Spree
        //string input = Console.ReadLine();
        //List<Person> persons = new List<Person>();
        //List<Product> productBase = new List<Product>();

        //string[] byers = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        //foreach (var byer in byers)
        //{
        //    string[] byerInformation = byer.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        //    try
        //    {
        //        Person person = new Person(byerInformation[0], decimal.Parse(byerInformation[1]));
        //        persons.Add(person);
        //    }
        //    catch (ArgumentException ae)
        //    {
        //        Console.WriteLine(ae.Message);
        //        return;
        //    }
        //}


        //input = Console.ReadLine();
        //string[] products = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        //foreach (var product in products)
        //{
        //    string[] productInformation = product.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        //    try
        //    {
        //        Product prod = new Product(productInformation[0], decimal.Parse(productInformation[1]));
        //        productBase.Add(prod);
        //    }
        //    catch (ArgumentException ae)
        //    {
        //        Console.WriteLine(ae.Message);
        //        return;
        //    }
        //}

        //input = Console.ReadLine();

        //while (input != "END")
        //{
        //    string[] purchase = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        //    Person currentPerson = persons.Find(x => x.Name == purchase[0]);
        //    Product currentProduct = productBase.Find(x => x.Name == purchase[1]);

        //    try
        //    {
        //        currentPerson.Buy(currentProduct);
        //        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
        //    }
        //    catch (ApplicationException ae)
        //    {
        //        Console.WriteLine(ae.Message);
        //    }
        //    input = Console.ReadLine();

        //}

        //if (persons.Count > 0)
        //{
        //    foreach (var person in persons)
        //    {
        //        if (person.Products.Count == 0)
        //        {
        //            Console.WriteLine($"{person.Name} - Nothing bought");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(x => x.Name))}");
        //        }
        //    }
        //}


        #endregion

        #region Problem 5.	Pizza Calories
        ////White Chewy 100
        ////Dough dough = new Dough("White", "Chewy", 100);
        ////Topping topping = new Topping("meat", 30);

        //Pizza pizza = new Pizza();
        ////List<Topping> toppings = new List<Topping>();
        //Dough dough;

        //string input = Console.ReadLine();
        //while (input != "END")
        //{

        //    string[] data = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        //    switch (data[0])
        //    {
        //        case "Pizza":
        //            try
        //            {
        //                pizza = new Pizza(data[1]);

        //            }
        //            catch (ApplicationException ae)
        //            {
        //                Console.WriteLine(ae.Message);
        //                return;
        //            }

        //            if (int.Parse(data[2]) > 10 || int.Parse(data[2]) < 0)
        //            {
        //                Console.WriteLine("Number of toppings should be in range [0..10].");

        //                return;
        //            }
        //            break;
        //        case "Topping":
        //            try
        //            {
        //                Topping currentTopping = new Topping(data[1], double.Parse(data[2]));
        //                //toppings.Add(currentTopping);
        //                if (pizza.Name == null)
        //                {
        //                    Console.WriteLine($"{currentTopping.GetCaloriesPerGram():f2}");
        //                }
        //                else
        //                {
        //                    pizza.AddTopping(currentTopping);
        //                }

        //            }
        //            catch (ApplicationException ae)
        //            {
        //                Console.WriteLine(ae.Message);
        //                return;

        //            }
        //            break;
        //        case "Dough":
        //            try
        //            {
        //                dough = new Dough(data[1], data[2], double.Parse(data[3]));
        //                if (pizza.Name == null)
        //                {
        //                    Console.WriteLine($"{dough.GetCaloriesPerGram():f2}");
        //                }
        //                else
        //                {
        //                    string pName = pizza.Name;
        //                    pizza = new Pizza(pName, dough);
        //                }


        //            }
        //            catch (ApplicationException ae)
        //            {
        //                Console.WriteLine(ae.Message);
        //                return;
        //            }
        //            break;
        //    }

        //    input = Console.ReadLine();
        //}

        //if (pizza.Name != null)
        //{
        //    //foreach (var topping in toppings)
        //    //{
        //    //    pizza.AddTopping(topping);
        //    //}
        //    Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
        //}



        #endregion

        #region Problem 6.	**Football Team Generator

        string input = Console.ReadLine();
        Dictionary<string, Team> teams = new Dictionary<string, Team>();

        while (input != "END")
        {
            string[] data = input.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            switch (data[0])
            {
                case "Team":
                    //Team;Arsenal
                    TeamOption(teams, data);
                    break;
                case "Add":
                    //Add;Arsenal;Kieran_Gibbs;75;85;84;92;67
                    AddOption(teams, data);
                    break;
                case "Remove":
                    //Remove;Arsenal;Aaron_Ramsey
                    RemoveOption(teams, data);
                    break;
                case "Rating":
                    //Rating;Arsenal
                    RatingOption(teams, data);
                    break;
            }
            input = Console.ReadLine();
        }

        #endregion
    }

    private static void RatingOption(Dictionary<string, Team> teams, string[] data)
    {
        if (teams.ContainsKey(data[1]))
        {
            Console.WriteLine($"{data[1]} - {teams[data[1]].Rating}");
        }
        else
        {
            Console.WriteLine($"Team {data[1]} does not exist.");
        }
    }

    private static void RemoveOption(Dictionary<string, Team> teams, string[] data)
    {
        if (teams.ContainsKey(data[1]))
        {
            try
            {
                teams[data[1]].RemovePlayer(data[2]);

            }
            catch (ApplicationException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
        else
        {
            Console.WriteLine($"Team {data[1]} does not exist.");
        }
    }

    private static void AddOption(Dictionary<string, Team> teams, string[] data)
    {
        if (teams.ContainsKey(data[1]))
        {
            string name = data[2];
            double endurance = double.Parse(data[3]);
            double sprint = double.Parse(data[4]);
            double dribble = double.Parse(data[5]);
            double passing = double.Parse(data[6]);
            double shooting = double.Parse(data[7]);
            try
            {
                Player currentPlayer = new Player(name, endurance, sprint, dribble, passing, shooting);
                teams[data[1]].AddPlayer(currentPlayer);

            }
            catch (ApplicationException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
        else
        {
            Console.WriteLine($"Team {data[1]} does not exist.");
        }
    }

    private static void TeamOption(Dictionary<string, Team> teams, string[] data)
    {
        teams[data[1]] = new Team(data[1]);
    }
}

