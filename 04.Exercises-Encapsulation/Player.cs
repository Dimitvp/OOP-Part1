using System;

class Player
{
    //A player has a name and stats which are the basis for his skill level.The stats a player has are endurance, sprint, dribble, passing and shooting.Each stat can be in the range[0..100]. The overall skill level of a player is calculated as the average of his stats.Only the name of a player and his stats should be visible to all of the outside world.

    private string name;
    private double endurance;
    private double sprint;
    private double dribble;
    private double passing;
    private double shooting;

    public Player(string name, double endurance, double sprint, double dribble, double passing, double shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
    }

    public double Stats => (endurance + sprint + dribble + passing + shooting) / 5.00;

    private double Shooting
    {
        get { return shooting; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                this.shooting = value;
            }
            else
            {
                throw new ApplicationException($"Shooting should be between 0 and 100.");
            }

        }
    }

    private double Passing
    {
        get { return passing; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                this.passing = value;
            }
            else
            {
                throw new ApplicationException($"Passing should be between 0 and 100.");
            }
        }
    }

    private double Dribble
    {
        get { return dribble; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                this.dribble = value;
            }
            else
            {
                throw new ApplicationException($"Dribble should be between 0 and 100.");
            }
        }
    }

    private double Sprint
    {
        get { return sprint; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                this.sprint = value;
            }
            else
            {
                throw new ApplicationException($"Sprint should be between 0 and 100.");
            }
        }
    }


    private double Endurance
    {
        get { return endurance; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                this.endurance = value;
            }
            else
            {
                throw new ApplicationException($"Endurance should be between 0 and 100.");
            }
        }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ApplicationException($"A name should not be empty.");
            }
            this.name = value;
        }
    }

}