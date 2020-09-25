using System;
using System.Collections;
using System.Numerics;

namespace ShapeLibrary
{
    class TriangleEnumerator : IEnumerator
    {
        private Vector2[] vertexArray;
        private int position = -1;
        public TriangleEnumerator(Vector2[] vector)
        {
            vertexArray = vector;
        }
        public object Current
        {
            get
            {
                try
                {
                    return vertexArray[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        public bool MoveNext()
        {
            position++;
            return (position < vertexArray.Length);
        }
        public void Reset()
        {
            position = -1;
        }
    }
}