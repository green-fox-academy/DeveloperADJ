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

            // draw four different size and color rectangles.
            // avoid code duplication.

            double rectangleWidth = 50;
            double rectangleHeight = 50;

            var center = new Point(Width/2, Width/2);

            Color[] colors = { Colors.Red, Colors.Blue, Colors.Yellow, Colors.Green };
            DrawFourRectangles(rectangleWidth, rectangleHeight, foxDraw, center, colors);




        }

        public static void DrawFourRectangles(double rectangleWidth, double rectangleHeight, FoxDraw foxDraw, Point center, Color[] colors) {
            for (int i = 0; i < 4; i++)
            {
                double newCenterX = center.X;
                double newCenterY = center.Y;

                if (i > 0) {
                    newCenterX += (rectangleWidth * i);
           
                }
                
                foxDraw.FillColor(colors[i]);
                foxDraw.DrawRectangle(newCenterX, newCenterY, rectangleWidth, rectangleHeight);
            }
            
                
            
            

        }



    }
}