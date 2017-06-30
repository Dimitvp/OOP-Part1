using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exercises_DefiningClasses
{
    class CorDraw
    {
        public static void Draw(string figureType, int figureWidth, int figureHeight = 0)
        {
            if (figureType == "Square")
            {
                Square.Draw(figureWidth);
            }
            else
            {
                Rectangle.Draw(figureWidth, figureHeight);
            }
        }
    }
}
