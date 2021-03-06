﻿using System;

public class Rectangle : Shape
{
    private double height;
    private double width;


    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }
    private double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }


    private double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }


    public override double CalculatePerimeter()
    {
        return 2 * (this.height + this.width);
    }

    public override double CalculateArea()
    {
        return this.height * this.width;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}

