using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Labb2
{
    class Program
    {
        static float totalTriangleCircumference = 0f;
        static List<Shape> shapes = new List<Shape>();
        static void Main(string[] args)
        {
            Add20RandomShapesToList();
            //Add20RandomShapesWithGivenCenterToList();
            //ForeachTriangle();
            PrintMyShapeList();
        }

        static List<Shape> Add20RandomShapesToList()
        {
            for (int i = 0; i < 20; i++)
            {
                shapes.Add(Shape.GenerateShape());
            }
            return shapes;
        }

        static List<Shape> Add20RandomShapesWithGivenCenterToList()
        {
            for (int i = 0; i < 20; i++)
            {
                shapes.Add(Shape.GenerateShape(new Vector3(3, 4, 0)));
            }
            return shapes;
        }

        static void PrintMyShapeList()
        {
            foreach (Shape item in shapes)
            {
                if (item is Triangle)
                {
                    var triangel = item as Triangle;
                    totalTriangleCircumference += triangel.Circumference;
                }
                Console.WriteLine(item);
            }
            Console.WriteLine("Totala triangelomkretsen: " + totalTriangleCircumference);
        }

        static void ForeachTriangle()
        {
            Triangle t = new Triangle(Vector2.Zero, Vector2.One, new Vector2(2.0f, .5f));

            foreach (Vector2 v in t)
            {
                Console.WriteLine(v);
            }
        }
    }
}