using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Startup
{
    static void Main(string[] args)
    {
        #region 01.Person
        //string name = Console.ReadLine();
        //int age = int.Parse(Console.ReadLine());

        //try
        //{
        //    Child child = new Child(name, age);
        //    Console.WriteLine(child);
        //}
        //catch (ArgumentException ae)
        //{
        //    Console.WriteLine(ae.Message);
        //}


        #endregion

        #region 02.BookShop
        //try
        //{
        //    string author = Console.ReadLine();
        //    string title = Console.ReadLine();
        //    decimal price = decimal.Parse(Console.ReadLine());

        //    Book book = new Book(title, author, price);
        //    GoldenEditionBook goldenEditionBook = new GoldenEditionBook(title, author, price);

        //    Console.WriteLine(book);
        //    Console.WriteLine(goldenEditionBook);
        //}
        //catch (ArgumentException ae)
        //{
        //    Console.WriteLine(ae.Message);
        //}



        #endregion

        #region 03.Mankind

        //try
        //{
        //    var studentData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        //    var firstName = studentData[0];
        //    var lastName = studentData[1];
        //    var facultyNumber = studentData[2];
        //    var student = new Student(firstName, lastName, facultyNumber);

        //    var workerData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        //    firstName = workerData[0];
        //    lastName = workerData[1];
        //    var weekSalary = decimal.Parse(workerData[2]);
        //    var hoursPerDay = double.Parse(workerData[3]);
        //    var worker = new Worker(firstName, lastName, weekSalary, hoursPerDay);
        //    Console.WriteLine(student);
        //    Console.WriteLine();
        //    Console.WriteLine(worker);
        //}
        //catch (ArgumentException ae)
        //{
        //    Console.WriteLine(ae.Message);
        //}



        #endregion

        #region 04. Online Radio Database

        //var songsCount = int.Parse(Console.ReadLine());
        //var songs = new List<Song>();
        //for (int i = 0; i < songsCount; i++)
        //{
        //    // ^(.*?);(.*?);((1[0-4])|([0-9])):([0-5]?[0-9])$
        //    try
        //    {
        //        var songData = Console.ReadLine();

        //        var regex = @"^(.*?);(.*?);((.*?):(.*?))$";

        //        var match = Regex.Match(songData, regex);

        //        var artist = match.Groups[1].ToString();
        //        var name = match.Groups[2].ToString();
        //        var time = match.Groups[3].ToString();
        //        var song = new Song(artist, name, time);
        //        songs.Add(song);
        //        Console.WriteLine("Song added.");
        //    }
        //    catch (InvalidSongException ise)
        //    {
        //        Console.WriteLine(ise.Message);
        //    }
        //}

        //    var totalDuration = songs.Sum(x => x.GetLenghtInSeconds());
        //    Console.WriteLine($"Songs added: {songs.Count}");
        //    Console.WriteLine($"Playlist length: {totalDuration / 3600}h {totalDuration / 60 % 60}m {totalDuration % 60}s");



        #endregion

        #region 05. Mordor's Cruelty Plan

        //List<FoodFactory> food = new List<FoodFactory>();

        //string[] input = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        ////string[] input = "Cram melon honeyCake Cake".ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        //foreach (var item in input)
        //{
        //    switch (item)
        //    {
        //        //Cram: 2 points of happiness;
        //        case "cram":
        //            food.Add(new Cram());
        //            break;

        //        //Lembas: 3 points of happiness;
        //        case "lembas":
        //            food.Add(new Lembas());
        //            break;

        //        //Apple: 1 point of happiness;
        //        case "apple":
        //            food.Add(new Apple());
        //            break;

        //        //Melon: 1 point of happiness;
        //        case "melon":
        //            food.Add(new Melon());
        //            break;

        //        //HoneyCake: 5 points of happiness;
        //        case "honeycake":
        //            food.Add(new HoneyCake());
        //            break;

        //        //Mushrooms: -10 points of happiness;
        //        case "mushrooms":
        //            food.Add(new Mushrooms());
        //            break;

        //        //Everything else: -1 point of happiness;
        //        default:
        //            food.Add(new Else());
        //            break;
        //    }
        //}
        //Console.WriteLine(food.Sum(x => x.Points));
        //Console.WriteLine(new Mood(food.Sum(x => x.Points)));



        #endregion

        #region 06. Animals

        var data = Console.ReadLine();

        while (data!= "Beast!")
        {
            try
            {
                var animal = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string animalName;
                int animalAge;
                string animalGender;

                if (animal.Length != 3)
                {
                    throw new ArgumentException("Invalid input!");
                }

                animalName = animal[0];
                if (!int.TryParse(animal[1], out animalAge))
                {
                    throw new ArgumentException("Invalid input!");
                }

                animalGender = animal[2];
                switch (data)
                {
                    case "Dog":
                        var dog = new Dog(animalName, animalAge, animalGender);
                        Console.WriteLine(dog.ProduceSound());
                        break;

                    case "Cat":
                        var cat = new Cat(animalName, animalAge, animalGender);
                        Console.WriteLine(cat.ProduceSound());
                        break;

                    case "Frog":
                        var frog = new Frog(animalName, animalAge, animalGender);
                        Console.WriteLine(frog.ProduceSound());
                        break;

                    case "Kitten":
                        var kitten = new Kitten(animalName, animalAge);
                        Console.WriteLine(kitten.ProduceSound());
                        break;

                    case "Tomcat":
                        var tomcat = new Tomcat(animalName, animalAge);
                        Console.WriteLine(tomcat.ProduceSound());
                        break;

                    default:
                        throw new ArgumentException("Invalid input!");
                }
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }

            data = Console.ReadLine();
        }

        #endregion
    }
}

