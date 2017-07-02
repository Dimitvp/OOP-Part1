using System;

class Dough
{
    private string bakingTechnique;
    private string typeOfFlour;
    private double weight;

    public Dough(string typeOfFlour, string bakingTechnique, double weight)
    {
        this.BakingTechnique = bakingTechnique;
        this.TypeOfFlour = typeOfFlour;
        this.Weight = weight;
    }

    private string BakingTechnique
    {
        get { return this.bakingTechnique; }
        set
        {
            if (value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade")
            {
                this.bakingTechnique = value.ToLower();
            }
            else
            {
                throw new ApplicationException("Invalid type of dough.");
            }
        }
    }

    private string TypeOfFlour
    {
        get { return this.typeOfFlour; }
        set
        {
            if (value.ToLower() == "white" || value.ToLower() == "wholegrain")
            {
                this.typeOfFlour = value.ToLower();
            }
            else
            {
                throw new ApplicationException("Invalid type of dough.");
            }
        }
    }

    private double Weight
    {
        get { return this.weight; }
        set
        {
            if (value >= 1 && value <= 200)
            {
                this.weight = value;
            }
            else
            {
                throw new ApplicationException("Dough weight should be in the range [1..200].");
            }
        }
    }


    public double GetCaloriesPerGram()
    {
        double baseMultiplier = 2;
        double flourMultiplier = 0;
        double bakingMultiplier = 0;

        switch (typeOfFlour)
        {
            case "white":
                flourMultiplier = 1.5;
                break;
            case "wholegrain":
                flourMultiplier = 1.0;
                break;
        }

        switch (bakingTechnique)
        {
            case "chewy":
                bakingMultiplier = 1.1;
                break;
            case "crispy":
                bakingMultiplier = 0.9;
                break;
            case "homemade":
                bakingMultiplier = 1.0;
                break;
        }
        return weight * (baseMultiplier * bakingMultiplier * flourMultiplier);
    }
}