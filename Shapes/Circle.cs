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
            Console.WriteLine("The area of this circle is: {0}.", PerimAreaCalc.CalculateArea(shapeSelected, this.radius));
            Console.WriteLine("The perimetere of this circle is: {0}.", PerimAreaCalc.CalculatePerimeter(shapeSelected, this.radius)); 
        }
/*
        public Double CalculateArea(double radius)
        {
            double area = (System.Math.PI * (this.radius * this.radius));
            return area;
        }

        public Double CalculatePerimeter(double radius)
        {
            double perimeter = (System.Math.PI * this.radius * 2);
            return perimeter;
        }
*/
        ~Circle()
        {
            Console.WriteLine("Destroying the circle with radius {0}.", this.radius);
        }
    }
}
