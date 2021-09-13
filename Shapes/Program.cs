using System;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            double a = 7;
            double b = 15;
            var initSquare = new Square(a);
            var initRectangle = new Rectangle(a, b);
            var initCircle = new Circle(a);
            var initEllipse = new Ellipse(a, b);
            var initPentagon = new Pentagon(a);
            Console.WriteLine("initSquare Area: {0}\ninitSquare Perimeter: {1}\n", initSquare.CalculateArea(), initSquare.CalculatePerimeter());
            Console.WriteLine("initRectangle Area: {0}\ninitRectangle Perimeter: {1}\n", initRectangle.CalculateArea(), initSquare.CalculatePerimeter());
            Console.WriteLine("initCircle Area: {0}\ninitCircle Perimeter: {1}\n", initCircle.CalculateArea(), initCircle.CalculatePerimeter());
            Console.WriteLine("initEllipse Area: {0}\ninitEllipse Perimeter: {1}\n", initEllipse.CalculateArea(), initEllipse.CalculatePerimeter());
            Console.WriteLine("initPentagon Area: {0}\ninitPentagon Perimeter: {1}\n\n", initPentagon.CalculateArea(), initPentagon.CalculatePerimeter());
            Shapes.ShapeCreation();
        }
    }
}