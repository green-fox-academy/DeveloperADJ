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

            //Draw a perfect triangle

            //(x + distance * Math.Cos(angle + Math.PI / 3))

            int angle = 0;
            int distance = -200;


            //Where the triangle starts drawing
            var startPoint = new Point((canvas.Width/2)-distance/2, (canvas.Height/2)-distance/2);

            //Top to right
            var point1X = startPoint.X + distance * Math.Cos(angle + Math.PI / 3);
            var point1Y = startPoint.Y + distance * Math.Sin(angle + Math.PI / 3);

            var point1 = new Point(point1X, point1Y);

            foxDraw.DrawLine(startPoint, point1);

            //Top to left
            var point2X = startPoint.X + distance * Math.Cos(angle);
            var point2Y = startPoint.Y + distance * Math.Sin(angle);
            var point2 = new Point(point2X, point2Y);

            foxDraw.DrawLine(point1, point2);

            foxDraw.DrawLine(point2, startPoint);







        }




    }
}