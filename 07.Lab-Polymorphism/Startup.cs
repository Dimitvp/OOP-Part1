using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Lab_Polymorphism
{
    class Startup
    {
        static void Main(string[] args)
        {

            #region 1.	MathOperation

            //MathOperations mo = new MathOperations();
            //Console.WriteLine(mo.Add(2, 3));
            //Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            //Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));


            #endregion

            #region 2.	Animals

            //Animal cat = new Cat("Pesho", "Whiskas");
            //Animal dog = new Dog("Gosho", "Meat");

            //Console.WriteLine(cat.ExplainMyself());
            //Console.WriteLine(dog.ExplainMyself());


            #endregion

            #region 3.	Shapes

            Shape rect = new Rectangle(10,10);
            Shape circ = new Circle(10);
            #endregion
        }
    }
}
