using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Pentagon
    {
        private readonly double LengthOfSide;

        public Pentagon()
        {
            Console.WriteLine("Initializing a new Pentagon instance. What side length do you wish to use?");
            this.LengthOfSide = double.Parse(Console.ReadLine());

        }

        public Pentagon(double a)
        {
            Console.WriteLine("Initializing a new Pentagon instance with side lengths of {0}.", a);
            LengthOfSide = a;
        }

        public double CalculateArea()
        {
            double area = (.25 * Math.Sqrt(5*(5+2*Math.Sqrt(5)))* LengthOfSide * LengthOfSide);
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = LengthOfSide * 5;
            return perimeter;
        }
        ~Pentagon()
        {
            Console.WriteLine("Destroying the pentagon with side length of {0}.", this.LengthOfSide);
        }
    }
}
