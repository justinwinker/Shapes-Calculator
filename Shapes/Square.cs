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
            Console.WriteLine("Initializing a new Square instance. What radius do you wish to use?");
            this.LengthOfSide = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of this circle is: {0}.", PerimAreaCalc.CalculateArea(shapeSelected, LengthOfSide));
            Console.WriteLine("The perimetere of this circle is: {0}.", PerimAreaCalc.CalculatePerimeter(shapeSelected, LengthOfSide));
        }
        /*
        public Double CalculateArea(double LengthOfSide)
        {
            double area = (this.LengthOfSide * this.LengthOfSide);
            return area;
        }

        public Double CalculatePerimeter(double LengthOfSide)
        {
            double perimeter = (this.LengthOfSide * 4);
            return perimeter;
        }
        */
        ~Square()
        {
            Console.WriteLine("Destroying the circle with side lengths of {0}.", this.LengthOfSide);
        }
    }
}
