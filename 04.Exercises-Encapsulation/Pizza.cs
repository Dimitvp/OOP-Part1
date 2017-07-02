using System;
using System.Collections.Generic;
using System.Linq;

class Pizza
{
    private string name;
    private List<Topping> toppings;
    private Dough dough;

    public Pizza(string name, Dough dough)
    {
        this.Name = name;
        this.dough = dough;
        this.toppings = new List<Topping>();
    }

    public Pizza(string name)
    {
        this.Name = name;
        this.toppings = new List<Topping>();
    }

    public Pizza()
    {
        this.toppings = new List<Topping>();
    }

    public int NumberOfToppings
    {
        get { return this.toppings.Count; }
    }

    public double TotalCalories
    {
        get
        {
            return this.toppings.Sum(x => x.GetCaloriesPerGram()) + this.dough.GetCaloriesPerGram();
        }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (!string.IsNullOrWhiteSpace(value) && (value.Length >= 0 && value.Length <= 15))
            {
                this.name = value;
            }
            else
            {
                throw new ApplicationException($"Pizza name should be between 1 and 15 symbols.");
            }

        }
    }

    public void AddTopping(Topping topping)
    {
        if (toppings.Count == 10)
        {
            throw new ApplicationException($"Number of toppings should be in range [0..10].");
        }
        this.toppings.Add(topping);
    }

}