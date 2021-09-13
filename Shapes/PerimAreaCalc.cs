using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class PerimAreaCalc
    {
        private double area;
        private double perimeter;
        public double CalculateArea(int a, double b) //Circle, Square, Pentagon. a = shape selected, b = side length/radius. 
        {
            switch (a) {
                case 1: //Square area
                    {
                        area = (b * b);
                        return area;
                    }
                case 3: //Circle area
                    {
                        area = (System.Math.PI * (b * b));
                        return area;
                    }
                case 5: //Pentagon area
                    {
                        area = (.25 * Math.Sqrt(5 * (5 + 2 * (Math.Sqrt(5)))) * b * b);
                        return area;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }

        public double CalculatePerimeter(int a, double b) //Circle, Square, Pentagon. a = shape selected, b = side length/radius. 
        {
            switch (a)
            {
                case 1: //Square perimeter
                    {
                        perimeter = (b * 4);
                        return perimeter;
                    }
                case 3: //Circle perimeter
                    {
                        perimeter = (Math.PI * 2 * b);
                        return perimeter;
                    }
                case 5: //Pentagon area
                    {
                        perimeter = b * 5;
                        return perimeter;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }

        public double CalculateArea(int a, double b, double c) //Rectangle, Ellipse. a = shape selected, b = first side/metric, c = second side/metric. 
        {
            switch (a)
            {
                case 2: //Rectangle area
                    {
                        area = b * c;
                        return area;
                    }
                case 4: //Ellipse area
                    {
                        area = Math.PI * b * c;
                        return area;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }

        public double CalculatePerimeter(int a, double b, double c)
        {
            switch (a)
            {
                case 2: //Rectangle perimeter
                    {
                        perimeter = 2 * b + 2 * c;
                        return perimeter; 
                    }
                case 4: //Ellipse area approximation using Ramanujan's approximation method. 
                    {
                        perimeter = Math.PI * (3 * (b + c) - Math.Sqrt((3 * b + c) * (3 * c + b)));
                        return perimeter;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
            
    }
}