using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Cuboid : Shape3D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Volume { get; }
        public bool IsCube { get; } = false;

        private float width, height, length;
        public Cuboid(Vector3 _center, Vector3 _size)
        {
            width = _size.X;
            height = _size.Y;
            length = _size.Z;

            Center = _center;
            Area = 2 * (width * height + height * length + length * width);
            Volume = width * height * length;
            if (_size.X == _size.Y && _size.Y == _size.Z)
            {
                IsCube = true;
            }
        }
        public Cuboid(Vector3 _center, float _width)
        {
            width = _width;
            height = _width;
            length = _width;

            Center = _center;
            Area = 2 * (width * height + height * length + length * width);
            Volume = width * height * length;
            IsCube = true;
        }
        public override string ToString()
        {
            if (IsCube == true)
            {
                return ($"Cube @ {Center:F1}: w = {width}, h = {height}, l = {length}");
            }
            else
            {
                return ($"Cuboid @ {Center:F1}: w = {width}, h = {height}, l = {length}");
            }
        }
    }
}