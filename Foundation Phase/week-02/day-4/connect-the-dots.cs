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

            var greenFox = new List<Point>();

            greenFox.Add(new Point(50, 100));
            greenFox.Add(new Point(70, 70));
            greenFox.Add(new Point(80, 90));
            greenFox.Add(new Point(90, 90));
            greenFox.Add(new Point(100, 70));
            greenFox.Add(new Point(120, 100));
            greenFox.Add(new Point(85, 130));
            greenFox.Add(new Point(50, 100));

            foxDraw.StrokeColor(Colors.White);
            foxDraw.BackgroundColor(Colors.Black);
            foxDraw.FillColor(Colors.Green);

            ConnectTheDots(greenFox);

            var box = new List<Point>();

            //Box
            box.Add(new Point(10, 10));
            box.Add(new Point(290, 10));
            box.Add(new Point(290, 290));
            box.Add(new Point(10, 290));
            foxDraw.FillColor(Color.FromArgb(0,0,0,0));

            ConnectTheDots(box);





            void ConnectTheDots(List<Point> inputPoints)
            {
                var from = inputPoints[0];
                var to = new Point(0,0);

                foreach (var point in inputPoints)
                {
                    to = point;
                    foxDraw.DrawPolygon(inputPoints);
                    from = point;
                }

            }

        }
    }
}