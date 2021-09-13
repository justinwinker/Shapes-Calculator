using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Ellipse
    {
        public double radiusA;
        public double radiusB;

        public Ellipse()
        {
            Console.WriteLine("Initializing a new Ellipse instance. What is the shortest radius?");
            this.radiusA = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the longest radius?");
            this.radiusB = double.Parse(Console.ReadLine());
        }

        public double CalculateArea()
        {
            double area = Math.PI * this.radiusA * this.radiusB;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = Math.PI * (3 * (this.radiusA + this.radiusB) - Math.Sqrt((3 * this.radiusA + this.radiusB) * (3 * this.radiusB + this.radiusA)));
            return perimeter;
        }

        ~Ellipse()
        {
            Console.WriteLine("Destroying the ellipse with side lengths of {0} and {1}.", this.radiusA, this.radiusB);
        }
    }
}
