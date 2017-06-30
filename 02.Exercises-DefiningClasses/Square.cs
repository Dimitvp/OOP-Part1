using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exercises_DefiningClasses
{
    class Square
    {
        public static void Draw(int size)
        {
            Console.WriteLine($"{'|'}{new string('-', size)}{'|'}");
            for (int i = 0; i < size - 2; i++)
            {
                Console.WriteLine($"{'|'}{new string(' ', size)}{'|'}");
            }
            Console.WriteLine($"{'|'}{new string('-', size)}{'|'}");

        }
    }
}
