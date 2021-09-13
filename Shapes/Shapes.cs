﻿using System;
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
            Console.WriteLine("What shapes would you like to create?\n[1] Square\n[2] Rectangle\n[3] Circle\n[4] Ellipse\n[5] Pentagon\n");
            int shapeSelected = int.Parse(Console.ReadLine());
        Console.WriteLine("You entered: {0}\n",shapeSelected);
            switch (shapeSelected)
            {
                case 1: //Square logic
                    var square1 = new Square(shapeSelected);
                    var square2 = new Square(shapeSelected);
                    Shapes.ShapeCreation();
                    break;
                case 2: //Rectangle logic
                    var rectangle1 = 1; //= new Rectangle(shapeSelected);
                    var rectangle2 = 1; //= new Rectangle(shapeSelected);
                    Shapes.ShapeCreation();
                    break;
                case 3: //Circle logic
                    var circle1 = new Circle(shapeSelected);
                    var circle2 = new Circle(shapeSelected);
                    Shapes.ShapeCreation();
                    break;
                case 4: //Ellipse logic
                    var ellipse1 = 1;
                    var ellipse2 = 2;
                    Shapes.ShapeCreation();
                    break;
                case 5: //Pentagon logic
                    var pentagon1 = 1;
                    var pentagon2 = 2;
                    Shapes.ShapeCreation();
                    break;
                default:
                    Console.WriteLine("You selected an invalid option. Please try again.");
                    Shapes.ShapeCreation();
                    break;
            }
        }
    }
}