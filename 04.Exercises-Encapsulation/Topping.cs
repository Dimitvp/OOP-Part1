using System;

class Topping
{
    private double weight;
    private string typeOfTopping;

    public Topping(string typeOfTopping, double weight)
    {
        this.TypeOfTopping = typeOfTopping;
        this.Weight = weight;

    }

    private string TypeOfTopping
    {
        get { return this.typeOfTopping; }
        set
        {
            if (value.ToLower() == "meat" || value.ToLower() == "veggies" || value.ToLower() == "cheese" || value.ToLower() == "sauce")
            {
                this.typeOfTopping = value;
            }
            else
            {
                throw new ApplicationException($"Cannot place {value} on top of your pizza.");
            }
        }
    }

    private double Weight
    {
        get { return this.weight; }
        set
        {
            if (value >= 1 && value <= 50)
            {
                this.weight = value;
            }
            else
            {
                throw new ApplicationException($"{typeOfTopping} weight should be in the range [1..50].");
            }

        }
    }
    public double GetCaloriesPerGram()
    {
        double baseMultiplier = 2;
        double toppingMultiplier = 0;


        switch (typeOfTopping.ToLower())
        {
            case "meat":
                toppingMultiplier = 1.2;
                break;
            case "veggies":
                toppingMultiplier = 0.8;
                break;
            case "cheese":
                toppingMultiplier = 1.1;
                break;
            case "sauce":
                toppingMultiplier = 0.9;
                break;
        }
        return weight * baseMultiplier * toppingMultiplier;
    }
}