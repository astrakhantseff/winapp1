using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Line
    {
        public float A { get; }
        public float B { get; }
        public float C { get; }

        public Line(Point p1, Point p2)
        {
            A = p2.Y - p1.Y;
            B = p1.X - p2.X;
            C = A * p1.X + B * p1.Y;
        }

        public bool IntersectsWith(RectangleF rectangle)
        {
            // Проверка пересечения прямой и прямоугольника
            var topLeft = new PointF(rectangle.Left, rectangle.Top);
            var topRight = new PointF(rectangle.Right, rectangle.Top);
            var bottomLeft = new PointF(rectangle.Left, rectangle.Bottom);
            var bottomRight = new PointF(rectangle.Right, rectangle.Bottom);

            return (IsOnDifferentSides(topLeft, topRight) ||
                    IsOnDifferentSides(topLeft, bottomLeft) ||
                    IsOnDifferentSides(bottomLeft, bottomRight) ||
                    IsOnDifferentSides(bottomRight, topRight)) ||
                   rectangle.Contains(new PointF(A, -B));
        }

        private bool IsOnDifferentSides(PointF p1, PointF p2)
        {
            return (A * p1.X + B * p1.Y - C) * (A * p2.X + B * p2.Y - C) <= 0;
        }
    }
}
