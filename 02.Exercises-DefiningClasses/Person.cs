using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{
    public string name;
    public int age;

    public Person()
    {
        this.age = 1;
        this.name = "No name";
    }

    public Person(int age)
        :this()
    {
        this.age = age;
    }

    public Person(string name, int age)
        :this(age)
    {
        this.name = name;
    }
}

