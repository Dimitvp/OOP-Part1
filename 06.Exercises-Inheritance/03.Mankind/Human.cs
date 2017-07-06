using System;

class Human
{
    private string firstName;
    private string lastname;

    public Human(string firstName, string lastname)
    {
        this.FirstName = firstName;
        this.LastName = lastname;
    }

    private string LastName
    {
        get { return this.lastname; }
        set
        {
                if (!Char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }


            if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            this.lastname = value;

        }
    }
    private string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (!Char.IsUpper(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }


            if (value.Length < 4)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            this.firstName = value;
        }
    }

    public override string ToString()
    {
        return $"First Name: {this.FirstName}\nLast Name: {this.lastname}";
    }
}
