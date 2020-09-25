using System.Numerics;
using System;


namespace ShapeLibrary
{
    public class Rectangle : Shape2D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Circumference { get; }

        public bool IsSquare { get; } = false;
        private float width, height;
        public Rectangle(Vector2 _center, Vector2 _size)
        {
            width = _size.X;
            height = _size.Y;

            Center = new Vector3(_center, 0);
            Area = width * height;
            if (width == height)
            {
                IsSquare = true;
            }
        }
        public Rectangle(Vector2 _center, float _width)
        {
            width = _width;
            height = _width;
            Center = new Vector3(_center, 0);
            Area = width * height;
            IsSquare = true;
        }
        public override string ToString()
        {
            if (IsSquare)
            {
                return ($"Square @ {Center}: w = {width}, h = {height}");
            }
            else
            {
                return ($"Rectangle @ {Center}: w = {width}, h = {height}");
            }
        }
    }
}