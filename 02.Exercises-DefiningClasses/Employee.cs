using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class Employee that holds the following information: name, salary, position, department, email and age.The name, salary, position and department are mandatory while the rest are optional.
class Employee
{
    private string name;
    private double salary;
    private string position;
    private string department;

    private string email;
    private int age;

    public Employee(string name, double salary, string position, string department)
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Department = department;
        this.Email = "n/a";
        this.age = -1;
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }


    public string Department
    {
        get { return department; }
        set { department = value; }
    }


    public string Position
    {
        get { return position; }
        set { position = value; }
    }


    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }


}

