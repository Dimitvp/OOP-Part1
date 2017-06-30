using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{

    //public string name;
    //public int age;

    //public Person()
    //{
    //    this.age = 1;
    //    this.name = "No name";
    //}

    //public Person(int age)
    //    :this()
    //{
    //    this.age = age;
    //}

    //public Person(string name, int age)
    //    :this(age)
    //{
    //    this.name = name;
    //}

    #region Problem 13.	Family Tree
    public Person(string name, string dateOfBirth)
    {
        this.Name = name;
        this.DateOfBirth = dateOfBirth;
        this.Parents = new List<Person>();
        this.Childs = new List<Person>();
    }

    public List<Person> Parents { get; set; }
    public List<Person> Childs { get; set; }
    public string Name { get; set; }
    public string DateOfBirth { get; set; }
    #endregion
}

