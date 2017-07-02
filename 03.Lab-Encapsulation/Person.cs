using System;

class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }
    public int Age
    {
        get { return age; }
        private set
        {
            if (value > 0)
            {
                age = value;
            }
            else
            {
                throw new ArgumentException("Age cannot be zero or negative integer");
            }
           
        }
    }


    public string LastName
    {
        get { return lastName; }
        private set
        {
            if (value.Length > 3)
            {
                lastName = value;

            }
            else
            {
                throw new ArgumentException("Last name cannot be less than 3 symbols");
            }
        }
    }


    public string FirstName
    {
        get { return firstName; }
        private set
        {
            if (value.Length > 3)
            {
                firstName = value;

            }
            else
            {
                throw new ArgumentException("First name cannot be less than 3 symbols");
            }
        }
    }

    public double Salary
    {
        get { return salary; }
        private set
        {
            if (value >= 460)
            {
                this.salary = value;
            }
            else
            {
                throw new ArgumentException("Salary cannot be less than 460 leva");
            }
        }
    }

    public void IncreaseSalary(double precet)
    {
        if (this.age > 30)
        {
            this.salary += this.salary * precet / 100;
        }
        else
        {
            this.salary += this.salary * precet / 200;

        }
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
    }
}

