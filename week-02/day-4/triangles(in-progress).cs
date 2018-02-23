using GreenFox;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;


namespace drawing
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int angle = 0;


            DrawTrianglesWithWidth(-50);

            void DrawTrianglesWithWidth(int triangleSize)
            {
                //Where the triangle starts drawing
                var startPoint = new Point((canvas.Width / 2) - triangleSize / 2, (canvas.Height / 2) - triangleSize / 2);

                //Right surface
                var point1X = startPoint.X + triangleSize * Math.Cos(angle + Math.PI / 3);
                var point1Y = startPoint.Y + triangleSize * Math.Sin(angle + Math.PI / 3);

                var point1 = new Point(point1X, point1Y);

                //Left surface
                var point2X = startPoint.X + triangleSize * Math.Cos(angle);
                var point2Y = startPoint.Y + triangleSize * Math.Sin(angle);
                var point2 = new Point(point2X, point2Y);

                foxDraw.DrawLine(startPoint, point1);
                foxDraw.DrawLine(point1, point2);
                foxDraw.DrawLine(point2, startPoint);

                for (int i = 1; i < 21; i++)
                {

                    int shift = triangleSize * i;

                    //Create another loop //

                    //Shift the X axis
                    foxDraw.DrawLine(new Point(startPoint.X + shift, startPoint.Y), new Point(point1.X + shift, point1.Y));
                    foxDraw.DrawLine(new Point(point1.X + shift, point1.Y), new Point(point2.X + shift, point2.Y));
                    foxDraw.DrawLine(new Point(point2.X + shift, point2.Y), new Point(startPoint.X + shift, startPoint.Y));
                    //

                    //Shift the Y axis

                }

                for (int i = 1; i < 5; i++)
                {

                    int shift = triangleSize * i;

                    foxDraw.DrawLine(new Point(startPoint.X, startPoint.Y + shift), new Point(point1.X, point1.Y + shift));
                    foxDraw.DrawLine(new Point(point1.X, point1.Y + shift), new Point(point2.X, point2.Y + shift));
                    foxDraw.DrawLine(new Point(point2.X, point2.Y + shift), new Point(startPoint.X, startPoint.Y + shift));

                }


            }


        }

    }
}