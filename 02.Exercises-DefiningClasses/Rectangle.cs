using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double[] topLeft;

    public Rectangle(string id, double width, double height, double[] topLeft)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.topLeft = new double[] {topLeft[0], topLeft[1]};
    }

    public static bool Intersect(Rectangle r1, Rectangle r2)
    {
        bool intersect = false;

        //A.X1 < B.X2:	
        //A.X2 > B.X1:	
        //A.Y1 < B.Y2:	
        //A.Y2 > B.Y1:	


        //2 1
        //Pesho 2 2 0 0
        //Gosho 2 2 0 0
        //Pesho Gosho

        if (Math.Abs(r1.topLeft[0]) < Math.Abs(r2.topLeft[0] + r2.width))
        {
            if (Math.Abs(r1.topLeft[0] + r1.width) >= Math.Abs(r2.topLeft[0]))
            {
                if (r1.topLeft[1] < Math.Abs((r2.topLeft[1] - r2.height)))
                {
                    if (Math.Abs(r1.topLeft[1] + r1.height) >= Math.Abs(r2.topLeft[1]))
                    {
                        intersect = true;
                    }
                }
            }
        }

        return intersect;
    }

    public static void Draw(int width, int height)
    {
        Console.WriteLine($"{'|'}{new string('-', width)}{'|'}");
        for (int i = 0; i < height - 2; i++)
        {
            Console.WriteLine($"{'|'}{new string(' ', width)}{'|'}");
        }
        Console.WriteLine($"{'|'}{new string('-', width)}{'|'}");

    }
}