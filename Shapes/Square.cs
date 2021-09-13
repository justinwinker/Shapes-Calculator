using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square
    {
        private readonly double LengthOfSide;

        public Square()
        {
            Console.WriteLine("Initializing a new Square instance. What side length does the square have?");
            this.LengthOfSide = double.Parse(Console.ReadLine());
        }

        public Square(double a)
        {
            Console.WriteLine("Initializing a new Square instance with side lengths of {0}.", a);
            LengthOfSide = a;
        }

        public double CalculateArea()
        {
            double area = LengthOfSide * LengthOfSide;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = LengthOfSide * 4;
            return perimeter;
        }

        ~Square()
        {
            Console.WriteLine("Destroying the square with side lengths of {0}.", LengthOfSide);
        }
    }
}
