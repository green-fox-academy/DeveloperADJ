using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace HexagonRecursion
{
    public class Graphics
    {
        private Canvas canvas;
        private SolidColorBrush LineColor { get; set; } = SystemColors.WindowFrameBrush;

        public Graphics(Canvas canvas)
        {
            this.canvas = canvas;
        }

        public void DrawLine(Point Start, Point End)
        {
            Line myLine = new Line()
            {
                Stroke = LineColor,
                X1 = Start.X,
                Y1 = Start.Y,
                X2 = End.X,
                Y2 = End.Y
            };
            canvas.Children.Add(myLine);
        }

        public double DrawHexagon(Point center, double size, double depth)
        {

            double angle = 45;

            if (depth == 0)
            {
                return 1;
            }
            else
            {
                var topLeft = new Point(center.X - (size * Math.Cos(-angle)), center.Y + (size * Math.Sin(-angle)));
                var topRight = new Point(center.X + (size * Math.Cos(-angle)), center.Y + (size * Math.Sin(-angle)));
                var bottomLeft = new Point(center.X - (size * Math.Cos(angle)), center.Y + (size * Math.Sin(angle)));
                var bottomRight = new Point(center.X + (size * Math.Cos(angle)), center.Y + (size * Math.Sin(angle)));
                var left = new Point(center.X - size, center.Y);
                var right = new Point(center.X + size, center.Y);

                DrawLine(topLeft, topRight);
                DrawLine(topRight, right);
                DrawLine(right, bottomRight);
                DrawLine(bottomRight, bottomLeft);
                DrawLine(bottomLeft, left);
                DrawLine(left, topLeft);

                DrawHexagon(new Point(center.X - (size * Math.Cos(-angle) / 2), center.Y + (size * Math.Sin(-angle) / 2)), size / 2, depth - 1);
                DrawHexagon(new Point(center.X - (size * Math.Cos(-angle) / 2), center.Y + (size * Math.Sin(angle) / 2)), size / 2, depth - 1);
                DrawHexagon(new Point(center.X + size/2, center.Y), size / 2, depth - 1);

                return depth - 1;
            }
        }
    }
}
