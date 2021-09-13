using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle
    {
        private readonly double radius;

        public Circle()
        {
            Console.WriteLine("Initializing a new Circle instance. What radius do you wish to use?");
            this.radius = double.Parse(Console.ReadLine());
        }

        public Circle(double a)
        {
            Console.WriteLine("Initializing a new Circle instance with radius of {0}.", a);
            radius = a;
        }

        public double CalculateArea()
        {
            double area = Math.PI * this.radius * this.radius;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = this.radius * 2 * Math.PI;
            return perimeter;
        }

        ~Circle()
        {
            Console.WriteLine("Destroying the circle with radius {0}.", this.radius);
        }
    }
}
