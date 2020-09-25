using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Circle : Shape2D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Circumference { get; }
        private float radius;

        public Circle(Vector2 _center, float _radius)
        {
            radius = _radius;
            Center = new Vector3(_center, 0);
            Circumference = (_radius * 2) * MathF.PI;
            Area = (_radius * _radius) * MathF.PI;
        }

        public override string ToString()
        {
            return ($"Circle @ <{Center.X}  {Center.Y}> Radius: {radius}");
        }
    }
}