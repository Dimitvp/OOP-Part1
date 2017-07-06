using System;
using System.Linq;

class Student:Human
{
    private string facultyNumber;


    public Student(string firstName, string lastname, string facultyNumber) 
        : base(firstName, lastname)
    {
        this.FacultyNumber = facultyNumber;
    }

    private string FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if (value.Length < 5 || value.Length > 10 || !value.All(char.IsLetterOrDigit))
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            
            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"\nFaculty number: {this.facultyNumber}";
    }
}

