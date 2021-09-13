using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square
    {
        private double LengthOfSide;

        public Square(int shapeSelected)
        {
            Console.WriteLine("Initializing a new Square instance. What side length does the square have?");
            this.LengthOfSide = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of this square is: {0}.", PerimAreaCalc.CalculateArea(shapeSelected, LengthOfSide));
            Console.WriteLine("The perimeter of this square is: {0}.", PerimAreaCalc.CalculatePerimeter(shapeSelected, LengthOfSide));
        }

        ~Square()
        {
            Console.WriteLine("Destroying the square with side lengths of {0}.", this.LengthOfSide);
        }
    }
}
