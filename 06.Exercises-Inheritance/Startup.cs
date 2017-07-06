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

        var songsCount = int.Parse(Console.ReadLine());
        var songs = new List<Song>();
        for (int i = 0; i < songsCount; i++)
        {
            // ^(.*?);(.*?);((1[0-4])|([0-9])):([0-5]?[0-9])$
            try
            {
                var songData = Console.ReadLine();

                var regex = @"^(.*?);(.*?);((.*?):(.*?))$";

                var match = Regex.Match(songData, regex);

                var artist = match.Groups[1].ToString();
                var name = match.Groups[2].ToString();
                var time = match.Groups[3].ToString();
                var song = new Song(artist, name, time);
                songs.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (InvalidSongException ise)
            {
                Console.WriteLine(ise.Message);
            }
        }

            var totalDuration = songs.Sum(x => x.GetLenghtInSeconds());
            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine($"Playlist length: {totalDuration / 3600}h {totalDuration / 60 % 60}m {totalDuration % 60}s");
        


        #endregion
    }
}

