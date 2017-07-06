using System;

class Worker:Human
{
    private decimal weekSalary;
    private double workHoursPerDay;

    public Worker(string firstName, string lastname, decimal weekSalary, double workHoursPerDay) 
        : base(firstName, lastname)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    private double WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workHoursPerDay = value;
        }
    }

    private decimal WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    private decimal GetEanPerHour()
    {
        return this.weekSalary / (Convert.ToDecimal(this.workHoursPerDay)*5);
    }

    public override string ToString()
    {
        return base.ToString() +
               $"\nWeek Salary: {weekSalary:f2}\nHours per day: {WorkHoursPerDay:f2}\nSalary per hour: {GetEanPerHour():f2}";
    }
}

