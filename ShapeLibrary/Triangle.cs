using System;
using System.Collections;
using System.Numerics;


namespace ShapeLibrary
{
    public class Triangle : Shape2D, IEnumerable
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Circumference { get; }

        private float sideAB, sideBC, sideCA;
        private Vector2[] vertexArray;
        public Triangle(Vector2 _p1, Vector2 _p2, Vector2 _p3)
        {
            sideAB = MathF.Sqrt(MathF.Pow((_p1.X - _p3.X), 2) + MathF.Pow((_p1.Y - _p3.Y), 2));
            sideBC = MathF.Sqrt(MathF.Pow((_p1.X - _p2.X), 2) + MathF.Pow((_p1.Y - _p2.Y), 2));
            sideCA = MathF.Sqrt(MathF.Pow((_p2.X - _p3.X), 2) + MathF.Pow((_p2.Y - _p3.Y), 2));

            Circumference = sideAB + sideBC + sideCA;
            Center = new Vector3((_p1.X + _p2.X + _p3.X) / 3, (_p1.Y + _p2.Y + _p3.Y) / 3, 0);
            Area = MathF.Sqrt((Circumference / 2) * ((Circumference / 2) - sideAB) * ((Circumference / 2) - sideBC) * ((Circumference / 2) - sideCA));

            vertexArray = new Vector2[3]
           {
               new Vector2(_p1.X, _p1.Y),
               new Vector2(_p2.X, _p2.Y),
               new Vector2(_p3.X, _p3.Y),
           };
        }
        public override string ToString()
        {
            return ($"Triangle @ <{Center.X}  {Center.Y}> P1: {vertexArray[0]}, P2: {vertexArray[1]}, P3: {vertexArray[1]}");
        }
        public IEnumerator GetEnumerator()
        {
            return new TriangleEnumerator(vertexArray);
        }
    }
}