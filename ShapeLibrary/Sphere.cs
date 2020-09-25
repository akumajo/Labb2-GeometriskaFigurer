using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Sphere : Shape3D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Volume { get; }
        private float radius;

        public Sphere(Vector3 _center, float _radius)
        {
            Center = _center;
            radius = _radius;
            Area = (MathF.PI * 4) * MathF.Pow(_radius, 2);
            Volume = (MathF.PI * 4) * MathF.Pow(_radius, 3) / 3;
        }

        public override string ToString()
        {
            return ($"Sphere @ {Center} Radius: {radius}");
        }
    }
}