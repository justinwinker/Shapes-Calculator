using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(int shapeSelected)
        {
            Console.WriteLine("Initializing a new Rectangle instance. What is the first side length?");
            this.sideA = int.Parse(Console.ReadLine());
            Console.WriteLine("Initializing a new Rectangle instance. What is the second side length?");
            this.sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of this rectangle is: {0}.", Calcs.CalculateArea(shapeSelected, this.sideA, this.sideB));
            Console.WriteLine("The perimeter of this rectangle is: {0}.", Calcs.CalculatePerimeter(shapeSelected, this.sideA, this.sideB));
        }

        ~Rectangle()
        {
            Console.WriteLine("Destroying the rectangle with side lengths of {0} and {1}.", this.sideA, this.sideB);
        }
    }
}
