using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    // Создаем класс для представления отрезков
    public class Segment
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Segment(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public bool IntersectsWith(RectangleF rectangle)
        {
            // Проверка пересечения отрезка и прямоугольника
            var line = new Line(Start, End);
            return line.IntersectsWith(rectangle);
        }
    }
}
