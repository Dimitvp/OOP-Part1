using System;
using System.Collections.Generic;

class Person
{
    // Each person should have a name, money and a bag of products. 

    private List<Product> products;
    private string name;
    private decimal money;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.products = new List<Product>();
    }

    public IReadOnlyCollection<Product> Products
    {
        get { return this.products.AsReadOnly(); }
    }
    

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }
    
    public decimal Money
    {
        get { return this.money; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }
    

    public void Buy(Product product)
    {
        if (this.money < product.Cost)
        {
            throw new ApplicationException($"{name} can't afford {product.Name}");
        }

        this.money -= product.Cost;
        this.products.Add(product);
    }


}