using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace drawing
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a function that takes 1 parameter:
            // A list of (x, y) points
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}

            Random rng = new Random();

            var points = new List<Point>();

            foxDraw.StrokeColor(Colors.White);
            foxDraw.BackgroundColor(Colors.Black);
            foxDraw.FillColor(Colors.Gray);

            for (int i = 0; i < 30; i++)
            {
                points.Add(new Point(rng.Next(700), rng.Next(700)));
            }


            ConnectTheDots(points);

            void ConnectTheDots(List<Point> inputPoints)
            {
                var from = inputPoints[0];
                var to = new Point(0,0);

                foreach (var point in inputPoints)
                {
                    to = point;
                    foxDraw.DrawLine(from, to);
                    from = point;
                }

            }





        }
    }
}