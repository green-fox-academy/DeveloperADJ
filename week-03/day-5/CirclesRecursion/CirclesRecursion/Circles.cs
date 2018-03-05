using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CirclesRecursion
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

        public void DrawCircle(double size, Point center, Canvas myCanvas)
        {
            Ellipse myEllipse = new Ellipse()
            {
                Stroke = LineColor,
                Width = size,
                Height = size
            };

             Canvas.SetLeft(myEllipse, center.X - size/2);
            Canvas.SetTop(myEllipse, center.Y - size/2);
            canvas.Children.Add(myEllipse);
        }

        public double DrawCircles(Point center, double size, double depth, Canvas myCanvas)
        {

            if (depth == 0)
            {
                return 1;
            }
            else
            {

                DrawCircle(size, center, myCanvas);

                DrawCircles(new Point(center.X, center.Y - size / 4), size / 2, depth - 1, myCanvas);
                DrawCircles(new Point(center.X, center.Y + ((Math.Sin(45) * size))), size / 2, depth - 1, myCanvas);

                return depth - 1;
            }
        }
    }
}
