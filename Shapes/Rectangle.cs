using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle
    {
        private readonly double sideA;
        private readonly double sideB;

        public Rectangle()
        {
            Console.WriteLine("Initializing a new Rectangle instance. What is the first side length?");
            this.sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the second side length?");
            this.sideB = double.Parse(Console.ReadLine());
        }

        public Rectangle(double a, double b)
        {
            Console.WriteLine("Initializing a new Rectangle instance with side lengths of {0} and {1}.", a, b);
            sideA = a;
            sideB = b;
        }

        public double CalculateArea()
        {
            double area = this.sideA * this.sideB;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = (this.sideA * 2) + (this.sideB * 2);
            return perimeter;
        }

        ~Rectangle()
        {
            Console.WriteLine("Destroying the rectangle with side lengths of {0} and {1}.", this.sideA, this.sideB);
        }
    }
}