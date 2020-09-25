using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Globalization;

namespace Labb2
{
    class Program
    {
        static float totalTriangleCircumference = 0f;
        static float sumOfAllAreas = 0f;
        static Shape3D biggestVolume;
        static List<Shape> shapes = new List<Shape>();
        
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("us");
            CultureInfo.DefaultThreadCurrentCulture = ci;

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
                    totalTriangleCircumference += (item as Triangle).Circumference;
                }
                if (item is Shape3D)
                {
                    biggestVolume = (item as Shape3D);

                    if ((item as Shape3D).Volume > biggestVolume.Volume)
                    {
                        biggestVolume = (item as Shape3D);
                    }
                }
                Console.WriteLine(item);
                sumOfAllAreas += item.Area;
            }
            var averageArea = sumOfAllAreas / shapes.Count;
            Console.WriteLine($"\n3DFormen med störst volym: {biggestVolume}" );
            Console.WriteLine($"Den genomsnittliga arean för alla former: {MathF.Round(averageArea)}");
            Console.WriteLine($"Totala triangelomkretsen: {MathF.Round(totalTriangleCircumference)}");
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