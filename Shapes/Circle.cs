using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle
    {
        private double radius;

        public Circle(int shapeSelected)
        {
            Console.WriteLine("Initializing a new Circle instance. What radius do you wish to use?");
            this.radius = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of this circle is: {0}.", Calcs.CalculateArea(shapeSelected, this.radius));
            Console.WriteLine("The perimeter of this circle is: {0}.", Calcs.CalculatePerimeter(shapeSelected, this.radius)); 
        }

        ~Circle()
        {
            Console.WriteLine("Destroying the circle with radius {0}.", this.radius);
        }
    }
}
