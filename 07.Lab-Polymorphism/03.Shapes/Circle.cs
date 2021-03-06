﻿using System;

public class Circle:Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    private double Radius
    {
        set { radius = value; }
    }


    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(this.radius, 2);
    }

    public override string Draw()
    {
       return base.Draw() + "Circle";
    }
}

