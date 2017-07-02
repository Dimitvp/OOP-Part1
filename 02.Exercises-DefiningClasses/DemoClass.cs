using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exercises_DefiningClasses
{
    class DemoClass
    {
        private int first;
        private int second;

        public int Second
        {
            get { return second; }
            set { second = value; }
        }


        public int First
        {
            get { return first; }
            set { first = value; }
        }

    }
}
