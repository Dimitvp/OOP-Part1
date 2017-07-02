using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Box
{
    #region Problem 1.	Class Box
    //// length, width and height
    //private double length;
    //private double width;
    //private double height;

    ////Surface Area – 52.00
    ////Lateral Surface Area – 40.00
    ////Volume – 24.00

    //public void GetSurfaceArea()
    //{
    //    // Surface Area = 2lw + 2lh + 2wh
    //    Console.WriteLine($"Surface Area - {(2 * (length * width + length * height + width * height)):f2}");
    //}

    //public void GetLateralSurface()
    //{
    //    // Lateral Surface Area = 2lh + 2wh
    //    Console.WriteLine($"Lateral Surface Area - {(2 * (length * height + width * height)):f2}");
    //}

    //public void GetVolume()
    //{
    //    //Volume = lwh
    //    Console.WriteLine($"Volume - {(length * height * width):f2}");

    //}

    //public Box(double width, double height, double length)
    //{
    //    this.width = width;
    //    this.height = height;
    //    this.length = length;
    //}


    #endregion

    #region Problem 2.	Class Box Data Validation

    // length, width and height
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get { return this.length; }
       private set
        {
            if (value <= 0.00)
            {
                throw new ApplicationException("Length cannot be zero or negative.");
            }
            this.length = value;
        }
    }

    public double Width
    {
        get { return this.length; }
        private set
        {
            if (value <= 0.00)
            {
                throw new ApplicationException("Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }
    public double Height {
        get { return this.length; }
        private set
        {
            if (value <= 0.00)
            {
                throw new ApplicationException("Height cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public void GetSurfaceArea()
    {
        // Surface Area = 2lw + 2lh + 2wh
        Console.WriteLine($"Surface Area - {(2 * (length * width + length * height + width * height)):f2}");
    }

    public void GetLateralSurface()
    {
        // Lateral Surface Area = 2lh + 2wh
        Console.WriteLine($"Lateral Surface Area - {(2 * (length * height + width * height)):f2}");
    }

    public void GetVolume()
    {
        //Volume = lwh
        Console.WriteLine($"Volume - {(length * height * width):f2}");

    }

    public Box(double width, double height, double length)
    {

        this.Width = width;
        this.Height = height;
        this.Length = length;
    }


    #endregion


}

