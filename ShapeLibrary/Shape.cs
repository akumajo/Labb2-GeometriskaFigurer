using System;
using System.Numerics;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        static Random rnd = new Random();
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
        public static Shape GenerateShape()
        {
            int randomShape = rnd.Next(7);

            switch (randomShape)
            {
                case 0:
                    return new Cuboid(new Vector3(RndFloat(), RndFloat(), RndFloat()), new Vector3(RndFloat(), RndFloat(), RndFloat()));
                case 1:
                    return new Sphere(new Vector3(RndFloat(), RndFloat(), RndFloat()), RndFloat());
                case 2:
                    return new Circle(new Vector2(RndFloat(), RndFloat()), RndFloat());
                case 3:
                    return new Triangle(new Vector2(RndFloat(), RndFloat()), new Vector2(RndFloat(), RndFloat()), new Vector2(RndFloat(), RndFloat()));
                case 4:
                    return new Rectangle(new Vector2(RndFloat(), RndFloat()), new Vector2(RndFloat(), RndFloat()));
                case 5:
                    return new Rectangle(new Vector2RndFloat(), RndFloat()), RndFloat()); // Square
                case 6:
                    return new Cuboid(new Vector3(RndFloat(), RndFloat(), RndFloat()), RndFloat()); //Cube
                default:
                    return null;
            }
        }
        public static Shape GenerateShape(Vector3 center)
        {
            int randomShape = rnd.Next(7);

            switch (randomShape)
            {
                case 0:
                    return new Cuboid(new Vector3(center.X, center.Y, center.Z), new Vector3(RndFloat(), RndFloat(), RndFloat()));
                case 1:
                    return new Sphere(new Vector3(center.X, center.Y, center.Z), RndFloat());
                case 2:
                    return new Circle(new Vector2(center.X, center.Y), RndFloat());
                case 3:
                    float[] p = CalculateTriangleWithGivenCentroid(center.X, center.Y);

                    return new Triangle(new Vector2(p[0], p[1]), new Vector2(p[2], p[3]), new Vector2(p[4], p[5]));
                case 4:
                    return new Rectangle(new Vector2(center.X, center.Y), new Vector2(RndFloat(), RndFloat()));
                case 5:
                    return new Cuboid(new Vector3(center.X, center.Y, center.Z), RndFloat()); //Cube
                case 6:
                    return new Rectangle(new Vector2(center.X, center.Y), RndFloat()); // Square
                default:
                    return null;
            }
        }
        public static float RndFloat()
        {
            return MathF.Round((float)rnd.NextDouble() *16,1);
        }
        public static float[] CalculateTriangleWithGivenCentroid(float centerX, float centerY)
        {
            float p1X = RndFloat();
            float p1Y = RndFloat();
            float p2X = RndFloat();
            float p2Y = RndFloat();

            float p3X = centerX * 3 - p1X - p2X;
            float p3Y = centerY * 3 - p1Y - p2Y;

            float[] vertexArray = { p1X, p1Y, p2X, p2Y, p3X, p3Y };

            return vertexArray;
        }
    }
}
