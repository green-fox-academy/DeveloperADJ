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

            var points = new List<Point>();

            int stepDistance = 10;
            int canvasHeight = Convert.ToInt32(canvas.Height);
            int canvasWidth = Convert.ToInt32(canvas.Width);

            foxDraw.StrokeColor(Color.FromRgb(0, 0, 0));

            Point bottomSide = new Point(0, canvasHeight);
            points.Add(bottomSide);
           
            Point leftSide = new Point(0, 0);
            points.Add(leftSide);

            foxDraw.DrawLine(bottomSide, leftSide);

            Random rng = new Random();

            for (int i = 1; i < canvas.Width; i+=stepDistance)
            {
                //Add X
                bottomSide.X += stepDistance;
                points.Add(new Point(bottomSide.X, canvasHeight));

                //Add Y
                leftSide.Y += stepDistance;
                points.Add(new Point(leftSide.X, leftSide.Y));

                foxDraw.DrawLine(bottomSide, leftSide);
            }


        }
    }
}