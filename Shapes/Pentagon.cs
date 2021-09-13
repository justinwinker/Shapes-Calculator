using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Pentagon
    {
        private double LengthOfSide;

        public Pentagon(int shapeSelected)
        {
            Console.WriteLine("Initializing a new Pentagon instance. What side length do you wish to use?");
            this.LengthOfSide = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of this pentagon is: {0}.", PerimAreaCalc.CalculateArea(shapeSelected, this.LengthOfSide));
            Console.WriteLine("The perimeter of this pentagon is: {0}.", PerimAreaCalc.CalculatePerimeter(shapeSelected, this.LengthOfSide));
        }

        ~Pentagon()
        {
            Console.WriteLine("Destroying the pentagon with side length of {0}.", this.LengthOfSide);
        }
    }
}
