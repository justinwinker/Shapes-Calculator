using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Ellipse
    {
        private double sideA;
        private double sideB;

        public Ellipse(int shapeSelected)
        {
            Console.WriteLine("Initializing a new Ellipse instance. What is the shortest diameter?");
            this.sideA = int.Parse(Console.ReadLine());
            Console.WriteLine("Initializing a new Ellipse instance. What is the longest diameter?");
            this.sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of this ellipse is: {0}.", PerimAreaCalc.CalculateArea(shapeSelected, this.sideA, this.sideB));
            Console.WriteLine("The approximate perimeter of this ellipse is: {0}.", PerimAreaCalc.CalculatePerimeter(shapeSelected, this.sideA, this.sideB));
        }

        ~Ellipse()
        {
            Console.WriteLine("Destroying the ellipse with side lengths of {0} and {1}.", this.sideA, this.sideB);
        }
    }
}
