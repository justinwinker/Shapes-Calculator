using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shapes
    {
        public static void ShapeCreation()
        {
                        // Call Shape Selection program
            Console.WriteLine("What shapes would you like to create?\n[1] Square\n[2] Rectangle\n[3] Circle\n[4] Ellipse\n[5] Pentagon\n[6] One of each Shape\n");
            int shapeSelected = int.Parse(Console.ReadLine());
        Console.WriteLine("You entered: {0}\n",shapeSelected);

            switch (shapeSelected)
            {
                case 1: //Square logic
                    var square1 = new Square();
                    var square2 = new Square();
                    Console.WriteLine("Area of square1: {0}\nArea of square2: {1}", square1.CalculateArea(), square2.CalculateArea());
                    Console.WriteLine("Perimeter of square1: {0}\nPerimeter of square2: {1}\n", square1.CalculatePerimeter(), square2.CalculatePerimeter());
                    GC.Collect();
                    Shapes.ShapeCreation();
                    break;
                case 2: //Rectangle logic
                    var rect1 = new Rectangle(); 
                    var rect2 = new Rectangle();
                    Console.WriteLine("Area of rect1: {0}\nArea of rect2: {1}", rect1.CalculateArea(), rect2.CalculateArea());
                    Console.WriteLine("Perimeter of rect1: {0}\nPerimeter of rect2: {1}\n", rect1.CalculatePerimeter(), rect2.CalculatePerimeter());
                    GC.Collect();
                    Shapes.ShapeCreation();
                    break;
                case 3: //Circle logic
                    var circle1 = new Circle();
                    var circle2 = new Circle();
                    Console.WriteLine("Area of circle1: {0}\nArea of circle2: {1}", circle1.CalculateArea(), circle2.CalculateArea());
                    Console.WriteLine("Perimeter of circle1: {0}\nPerimeter of circle2: {1}\n", circle1.CalculatePerimeter(), circle2.CalculatePerimeter());
                    GC.Collect();
                    Shapes.ShapeCreation();
                    break;
                case 4: //Ellipse logic
                    var ellipse1 = new Ellipse();
                    var ellipse2 = new Ellipse();
                    Console.WriteLine("Area of ellipse1: {0}\nArea of ellipse2: {1}", ellipse1.CalculateArea(), ellipse2.CalculateArea());
                    Console.WriteLine("Perimeter of ellipse1: {0}\nPerimeter of ellipse2: {1}\n", ellipse1.CalculatePerimeter(), ellipse2.CalculatePerimeter());
                    GC.Collect();
                    Shapes.ShapeCreation();
                    break;
                case 5: //Pentagon logic
                    var pentagon1 = new Pentagon();
                    var pentagon2 = new Pentagon();
                    Console.WriteLine("Area of pentagon1: {0}\nArea of pentagon2: {1}", pentagon1.CalculateArea(), pentagon2.CalculateArea());
                    Console.WriteLine("Perimeter of pentagon1: {0}\nPerimeter of pentagon2: {1}\n", pentagon1.CalculatePerimeter(), pentagon2.CalculatePerimeter());
                    GC.Collect();
                    Shapes.ShapeCreation();
                    break;
                case 6: //One of each shape
                    var squareA = new Square();
                    Console.WriteLine("Area of squareA: {0}\nPerimeter of squareA: {1}\n", squareA.CalculateArea(), squareA.CalculatePerimeter());
                    var rectA = new Rectangle();
                    Console.WriteLine("Area of rectA: {0}\nPerimeter of rectA: {1}\n", rectA.CalculateArea(), rectA.CalculatePerimeter());
                    var circleA = new Circle();
                    Console.WriteLine("Area of circleA: {0}\nPerimeter of circleA: {1}\n", circleA.CalculateArea(), circleA.CalculatePerimeter());
                    var ellipseA = new Ellipse();
                    Console.WriteLine("Area of ellipseA: {0}\nPerimeter of ellipseA: {1}\n", ellipseA.CalculateArea(), ellipseA.CalculateArea());
                    var pentagonA = new Pentagon();
                    Console.WriteLine("Area of pentagonA: {0}\nPerimeter of pentagonA: {1}\n", pentagonA.CalculateArea(), pentagonA.CalculateArea());
                    GC.Collect();
                    Shapes.ShapeCreation();
                    break;
                default:
                    Console.WriteLine("You selected an invalid option. Please try again.\n");
                    Shapes.ShapeCreation();
                    break;
            }
        }
    }
}
